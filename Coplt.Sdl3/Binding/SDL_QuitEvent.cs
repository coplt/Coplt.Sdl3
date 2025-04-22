namespace Coplt.Sdl3;

public partial struct SDL_QuitEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;
}
