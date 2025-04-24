using System;

namespace Coplt.Sdl3;

public static unsafe partial class SDL
{

    public static readonly byte* Prop_Surface_Sdr_White_Point_Float = StrPtr("SDL.surface.SDR_white_point"u8);

    public static readonly byte* Prop_Surface_Hdr_Headroom_Float = StrPtr("SDL.surface.HDR_headroom"u8);

    public static readonly byte* Prop_Surface_Tonemap_Operator_String = StrPtr("SDL.surface.tonemap"u8);

    public static readonly byte* Prop_Surface_HotspotX_Number = StrPtr("SDL.surface.hotspot.x"u8);

    public static readonly byte* Prop_Surface_HotspotY_Number = StrPtr("SDL.surface.hotspot.y"u8);

}
