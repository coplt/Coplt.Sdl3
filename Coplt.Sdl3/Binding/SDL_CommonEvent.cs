namespace Coplt.Sdl3;

public partial struct SDL_CommonEvent
{
    [NativeTypeName("Uint32")]
    public uint type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;
}
