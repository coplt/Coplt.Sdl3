using System;

namespace Coplt.Sdl3;

public static unsafe partial class SDL
{

    public static readonly byte* Prop_File_Dialog_Filters_Pointer = StrPtr("SDL.filedialog.filters"u8);

    public static readonly byte* Prop_File_Dialog_Nfilters_Number = StrPtr("SDL.filedialog.nfilters"u8);

    public static readonly byte* Prop_File_Dialog_Window_Pointer = StrPtr("SDL.filedialog.window"u8);

    public static readonly byte* Prop_File_Dialog_Location_String = StrPtr("SDL.filedialog.location"u8);

    public static readonly byte* Prop_File_Dialog_Many_Boolean = StrPtr("SDL.filedialog.many"u8);

    public static readonly byte* Prop_File_Dialog_Title_String = StrPtr("SDL.filedialog.title"u8);

    public static readonly byte* Prop_File_Dialog_Accept_String = StrPtr("SDL.filedialog.accept"u8);

    public static readonly byte* Prop_File_Dialog_Cancel_String = StrPtr("SDL.filedialog.cancel"u8);

}
