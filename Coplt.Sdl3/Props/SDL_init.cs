using System;

namespace Coplt.Sdl3;

public static unsafe partial class SDL
{

    public static readonly byte* Prop_App_Metadata_Name_String = StrPtr("SDL.app.metadata.name"u8);

    public static readonly byte* Prop_App_Metadata_Version_String = StrPtr("SDL.app.metadata.version"u8);

    public static readonly byte* Prop_App_Metadata_Identifier_String = StrPtr("SDL.app.metadata.identifier"u8);

    public static readonly byte* Prop_App_Metadata_Creator_String = StrPtr("SDL.app.metadata.creator"u8);

    public static readonly byte* Prop_App_Metadata_Copyright_String = StrPtr("SDL.app.metadata.copyright"u8);

    public static readonly byte* Prop_App_Metadata_Url_String = StrPtr("SDL.app.metadata.url"u8);

    public static readonly byte* Prop_App_Metadata_Type_String = StrPtr("SDL.app.metadata.type"u8);

}
