open System
open System.Collections.Generic
open System.IO
open System.Text
open System.Text.RegularExpressions
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Core

type List<'T> = System.Collections.Generic.List<'T>

let type_remaps = List<string>()

if not <| Directory.Exists "./Coplt.Sdl3/Structs" then
    ignore <| Directory.CreateDirectory("./Coplt.Sdl3/Structs")

let ignores = Set [ "MouseButton" ]

let is_flags = Set [ "GPUShaderFormat" ]

let type_map =
    Map
        [ "Uint64", "ulong"
          "Uint32", "uint"
          "Uint16", "ushort"
          "Uint8", "byte"
          "Int64", "long"
          "Int32", "int"
          "Int16", "short"
          "Int8", "sbyte" ]

[<Struct>]
type State =
    | None
    | TypeDef
    | Flags

let flags_regex =
    Regex(
        "typedef (?<type>Uint64|Uint32|Uint16|Uint8|Int64|Int32|Int16|Int8) SDL_((?<flags>(?<name>[\w]+)Flags)|(?<name>[\w]+));"
    )

let val_regex =
    Regex("(?<val>0x[\da-fA-F]+u)|SDL_UINT64_C\((?<val>0x[\da-fA-F]+)\)|\((?<val>\d+u << \d+)\)|(?<val>0)")

for path in File.ReadLines("./HeadersToGen.txt") do
    let flags = Dictionary<string, List<string>>()
    let new_types = List<string>()
    let mutable state = State.None
    let mutable cur_type = ""
    let mutable cur_name = ""
    let mutable def_name = ""
    let mutable cur_start = ""
    let mutable flags_suffix = ""
    let mutable cur_list = List<string>()

    for line in File.ReadLines($"./SDL/include/{path}") do
        match state with
        | None ->
            let mat = flags_regex.Match(line)

            if mat.Success then

                cur_type <- type_map[mat.Groups["type"].Value]
                cur_name <- mat.Groups["name"].Value

                if mat.Groups["flags"].Success || is_flags.Contains cur_name then
                    if ignores.Contains cur_name then
                        ()
                    else
                        state <- TypeDef

                        flags_suffix <- if mat.Groups["flags"].Success then "Flags" else ""

                        if cur_name = "MessageBoxButton" then
                            def_name <- $"MESSAGEBOX_BUTTON"
                        elif cur_name = "PenInput" then
                            def_name <- $"PEN_INPUT"
                        elif cur_name.StartsWith "GPU" then
                            def_name <- $"GPU_{cur_name.Substring(3).ToUpper()}"
                        else
                            def_name <- cur_name.ToUpper()

                        cur_start <- $"#define SDL_{def_name}_"
                        type_remaps.Add($"SDL_{cur_name}{flags_suffix}")
                        printfn $"\nFind flags {def_name}\nenum SDL_{cur_name}{flags_suffix} : {cur_type}\n{{"
                else
                    type_remaps.Add($"SDL_{cur_name}")
                    let new_type = $"readonly record struct SDL_{cur_name}({cur_type} Value);"
                    new_types.Add new_type
                    printfn $"\nFind new type\n{new_type}"
        | TypeDef -> state <- Flags
        | Flags ->
            if line.StartsWith cur_start then
                let after_start = line.Substring(cur_start.Length)
                let after_start = after_start.Substring(0, after_start.IndexOf(" "))

                let name =
                    String.Join(
                        "",
                        after_start.Split("_")
                        |> Seq.map _.ToLower()
                        |> Seq.map (fun s -> $"{s[0].ToString().ToUpper()}{s[1..]}")
                    )

                let mat = val_regex.Match(line)

                if mat.Success then
                    let v = mat.Groups["val"].Value

                    let item =
                        if cur_type = "byte" then
                            $"    {name} = ({cur_type})({v}),"
                        else
                            $"    {name} = {v},"

                    cur_list.Add item
                    printfn $"{item}"
                else
                    printfn "<ERROR>"
            else
                printfn "}"
                state <- State.None
                flags.Add($"public enum SDL_{cur_name}{flags_suffix} : {cur_type}", cur_list)
                cur_list <- List()

    if flags.Count > 0 || new_types.Count > 0 then
        let code = StringBuilder()
        ignore <| code.AppendLine("using System;\n")
        ignore <| code.AppendLine("namespace Coplt.Sdl3;")

        for item in flags do
            ignore <| code.AppendLine("\n[Flags]").AppendLine(item.Key).AppendLine("{")

            for item in item.Value do
                ignore <| code.AppendLine item

            ignore <| code.AppendLine("}")

        for new_type in new_types do
            ignore <| code.Append("\npublic ").AppendLine(new_type)

        let code = code.ToString()
        let file_name = Path.GetFileNameWithoutExtension path
        File.WriteAllText($"./Coplt.Sdl3/Structs/{file_name}.cs", code)

let gen_rsp () =
    let sb = StringBuilder()
    ignore <| sb.Append(File.ReadAllText("./GenerateBinding.rsp.template"))

    for typ in type_remaps do
        ignore <| sb.AppendLine($"{typ}={typ}")

    File.WriteAllText("./GenerateBinding.rsp", sb.ToString())

gen_rsp ()
