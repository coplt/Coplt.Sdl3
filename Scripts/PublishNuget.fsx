open System
open System.Diagnostics
open System.IO

let mutable NUGET_KEY = Environment.GetEnvironmentVariable("NUGET_KEY")

if NUGET_KEY = null then
    NUGET_KEY <- ""

for path in Directory.GetFiles "./artifact" do
    let child =
        Process.Start(
            "dotnet",
            [| "nuget"
               "push"
               path
               "--api-key"
               NUGET_KEY
               "--source"
               "https://api.nuget.org/v3/index.json" |]
        )

    child.WaitForExit()

    if child.ExitCode <> 0 then
        Environment.Exit child.ExitCode
