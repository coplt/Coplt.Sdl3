namespace Coplt.Sdl3;

public unsafe partial struct SDL_Surface
{
    [NativeTypeName("SDL_SurfaceFlags")]
    public uint flags;

    public SDL_PixelFormat format;

    public int w;

    public int h;

    public int pitch;

    public void* pixels;

    public int refcount;

    public void* reserved;
}
