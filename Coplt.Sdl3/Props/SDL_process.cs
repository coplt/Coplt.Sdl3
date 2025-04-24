using System;

namespace Coplt.Sdl3;

public static unsafe partial class SDL
{

    public static readonly byte* Prop_Process_Create_Args_Pointer = StrPtr("SDL.process.create.args"u8);

    public static readonly byte* Prop_Process_Create_Environment_Pointer = StrPtr("SDL.process.create.environment"u8);

    public static readonly byte* Prop_Process_Create_Stdin_Number = StrPtr("SDL.process.create.stdin_option"u8);

    public static readonly byte* Prop_Process_Create_Stdout_Number = StrPtr("SDL.process.create.stdout_option"u8);

    public static readonly byte* Prop_Process_Create_Stderr_Number = StrPtr("SDL.process.create.stderr_option"u8);

    public static readonly byte* Prop_Process_Create_Stderr_To_Stdout_Boolean = StrPtr("SDL.process.create.stderr_to_stdout"u8);

    public static readonly byte* Prop_Process_Create_Background_Boolean = StrPtr("SDL.process.create.background"u8);

    public static readonly byte* Prop_Process_Pid_Number = StrPtr("SDL.process.pid"u8);

    public static readonly byte* Prop_Process_Stdin_Pointer = StrPtr("SDL.process.stdin"u8);

    public static readonly byte* Prop_Process_Stdout_Pointer = StrPtr("SDL.process.stdout"u8);

    public static readonly byte* Prop_Process_Stderr_Pointer = StrPtr("SDL.process.stderr"u8);

    public static readonly byte* Prop_Process_Background_Boolean = StrPtr("SDL.process.background"u8);

}
