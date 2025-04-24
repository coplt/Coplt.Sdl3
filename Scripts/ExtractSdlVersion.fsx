open System.Collections.Generic
open System.IO
open System.Text.Json
open System.Text.RegularExpressions

let VersionRegex = Regex("\"([^\"]+)\"")

let version =
    VersionRegex
        .Match(
            File.ReadLines("./SDL/CMakeLists.txt")
            |> Seq.where (fun l -> l.StartsWith "project(SDL3")
            |> Seq.head
        )
        .Groups[1]
        .Value

let suffix = File.ReadAllText("./VersionSuffix.txt").Trim()

let version_output = $"{version}{suffix}"

let output =
    $"<Project>
    <PropertyGroup>
        <Version>{version_output}</Version>
    </PropertyGroup>
</Project>
"

File.WriteAllText("./Version.props", output)

let targets =
    Map
        [ "win-x64", "Coplt.Sdl3.Native.Win.x64"
          "win-arm64", "Coplt.Sdl3.Native.Win.Arm64"
          "linux-x64", "Coplt.Sdl3.Native.Linux.x64"
          "linux-arm64", "Coplt.Sdl3.Native.Linux.Arm64"
          "osx-x64", "Coplt.Sdl3.Native.Macos"
          "osx-arm64", "Coplt.Sdl3.Native.Macos" ]

type RuntimeJson =
    { runtimes: Dictionary<string, Dictionary<string, Dictionary<string, string>>> }

let runtimes: RuntimeJson = { runtimes = Dictionary() }

for target in targets do
    let dict0 = Dictionary()
    dict0.Add(target.Value, version_output)
    let dict1 = Dictionary()
    dict1.Add("Coplt.Sdl3.Native", dict0)
    runtimes.runtimes.Add(target.Key, dict1)

let json_options = JsonSerializerOptions()
json_options.WriteIndented <- true
let runtime_json = JsonSerializer.Serialize(runtimes, json_options)

File.WriteAllText("./Packages/Coplt.Sdl3.Native/runtime.json", runtime_json)
