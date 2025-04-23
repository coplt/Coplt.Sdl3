open System.IO
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

let suffix = File.ReadAllText("./VersionSuffix.txt").Trim();

let output = $"<Project>
    <PropertyGroup>
        <Version>{version}{suffix}</Version>
    </PropertyGroup>
</Project>
"

File.WriteAllText("./Version.props", output)
