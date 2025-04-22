namespace Coplt.Sdl3;

public partial struct SDL_TouchFingerEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_TouchID")]
    public ulong touchID;

    [NativeTypeName("SDL_FingerID")]
    public ulong fingerID;

    public float x;

    public float y;

    public float dx;

    public float dy;

    public float pressure;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;
}
