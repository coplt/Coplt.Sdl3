namespace Coplt.Sdl3;

public partial struct SDL_MouseWheelEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("SDL_MouseID")]
    public uint which;

    public float x;

    public float y;

    public SDL_MouseWheelDirection direction;

    public float mouse_x;

    public float mouse_y;
}
