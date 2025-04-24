using System;

namespace Coplt.Sdl3;

public static unsafe partial class SDL
{

    public static readonly byte* Prop_Textinput_Type_Number = StrPtr("SDL.textinput.type"u8);

    public static readonly byte* Prop_Textinput_Capitalization_Number = StrPtr("SDL.textinput.capitalization"u8);

    public static readonly byte* Prop_Textinput_Autocorrect_Boolean = StrPtr("SDL.textinput.autocorrect"u8);

    public static readonly byte* Prop_Textinput_Multiline_Boolean = StrPtr("SDL.textinput.multiline"u8);

    public static readonly byte* Prop_Textinput_Android_Inputtype_Number = StrPtr("SDL.textinput.android.inputtype"u8);

}
