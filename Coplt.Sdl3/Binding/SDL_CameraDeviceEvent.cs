namespace Coplt.Sdl3;

public partial struct SDL_CameraDeviceEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_CameraID")]
    public uint which;
}
