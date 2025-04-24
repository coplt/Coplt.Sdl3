using System;

namespace Coplt.Sdl3;

public static unsafe partial class SDL
{

    public static readonly byte* Prop_Thread_Create_Entry_Function_Pointer = StrPtr("SDL.thread.create.entry_function"u8);

    public static readonly byte* Prop_Thread_Create_Name_String = StrPtr("SDL.thread.create.name"u8);

    public static readonly byte* Prop_Thread_Create_Userdata_Pointer = StrPtr("SDL.thread.create.userdata"u8);

    public static readonly byte* Prop_Thread_Create_Stacksize_Number = StrPtr("SDL.thread.create.stacksize"u8);

}
