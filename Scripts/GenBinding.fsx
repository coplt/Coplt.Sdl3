open System.Diagnostics
open System.IO

for path in File.ReadLines("./HeadersToGen.txt") do
    let name = Path.GetFileNameWithoutExtension(path)

    let task =
        Process.Start(
            "ClangSharpPInvokeGenerator",
            $"--language=c -f {path} -o ./Coplt.Sdl3/Binding/{name}.cs @GenerateBinding.rsp"
        )

    task.WaitForExit()

#load "FixBinding.fsx"
