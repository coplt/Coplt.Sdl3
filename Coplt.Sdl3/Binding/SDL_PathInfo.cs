namespace Coplt.Sdl3;

public partial struct SDL_PathInfo
{
    public SDL_PathType type;

    [NativeTypeName("Uint64")]
    public ulong size;

    [NativeTypeName("SDL_Time")]
    public long create_time;

    [NativeTypeName("SDL_Time")]
    public long modify_time;

    [NativeTypeName("SDL_Time")]
    public long access_time;
}
