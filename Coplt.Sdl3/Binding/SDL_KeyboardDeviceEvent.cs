namespace Coplt.Sdl3;

public partial struct SDL_KeyboardDeviceEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_KeyboardID")]
    public uint which;
}
