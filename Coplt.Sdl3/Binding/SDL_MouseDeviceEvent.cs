namespace Coplt.Sdl3;

public partial struct SDL_MouseDeviceEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_MouseID")]
    public uint which;
}
