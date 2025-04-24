open System
open System.Collections.Generic
open System.IO
open System.Text
open System.Text.RegularExpressions
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Core

type List<'T> = System.Collections.Generic.List<'T>

if not <| Directory.Exists "./Coplt.Sdl3/Props" then
    ignore <| Directory.CreateDirectory("./Coplt.Sdl3/Props")

let enum_name_map (name: string) =
    String.Join(
        "",
        name.Split("_")
        |> Seq.map _.ToLower()
        |> Seq.map (fun s ->
            // let s = if s.Length > 0 && Char.IsNumber(s[0]) then $"_{s}" else s

            if s.Length <= 1 then
                s.ToUpper()
            else
                $"_{s[0].ToString().ToUpper()}{s[1..]}")
    )

let prop_regex =
    Regex("#define SDL_PROP_(?<name>[\w\d]+)_(?<type>[^_\s]+)\s+\"(?<val>[^\"]+)\"")

for path in File.ReadLines("./HeadersToGen.txt") do
    let props = Dictionary<string, struct (string * string)>()

    for line in File.ReadLines($"./SDL/include/{path}") do
        let mat = prop_regex.Match line

        if mat.Success then
            let name = mat.Groups["name"].Value
            let value = mat.Groups["val"].Value
            let typ = mat.Groups["type"].Value
            let name = enum_name_map name
            let typ = enum_name_map typ
            printfn $"Find prop: {name} ({typ}) => {value}"
            ignore <| props.TryAdd(name, struct (value, typ))

    if props.Count > 0 then
        let code = StringBuilder()
        ignore <| code.AppendLine("using System;\n")
        ignore <| code.AppendLine("namespace Coplt.Sdl3;\n")
        ignore <| code.AppendLine("public static unsafe partial class SDL")
        ignore <| code.AppendLine("{")

        for kv in props do
            let name = kv.Key
            let struct (value, typ) = kv.Value

            ignore
            <| code.AppendLine $"\n    public static readonly byte* Prop{name}{typ} = StrPtr(\"{value}\"u8);"

        ignore <| code.AppendLine("\n}")

        let code = code.ToString()
        let file_name = Path.GetFileNameWithoutExtension path
        File.WriteAllText($"./Coplt.Sdl3/Props/{file_name}.cs", code)
