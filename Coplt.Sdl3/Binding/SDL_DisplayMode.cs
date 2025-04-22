namespace Coplt.Sdl3;

public unsafe partial struct SDL_DisplayMode
{
    [NativeTypeName("SDL_DisplayID")]
    public uint displayID;

    public SDL_PixelFormat format;

    public int w;

    public int h;

    public float pixel_density;

    public float refresh_rate;

    public int refresh_rate_numerator;

    public int refresh_rate_denominator;

    public SDL_DisplayModeData* @internal;
}
