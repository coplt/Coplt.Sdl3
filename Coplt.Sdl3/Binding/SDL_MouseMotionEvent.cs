namespace Coplt.Sdl3;

public partial struct SDL_MouseMotionEvent
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

    [NativeTypeName("SDL_MouseButtonFlags")]
    public uint state;

    public float x;

    public float y;

    public float xrel;

    public float yrel;
}
