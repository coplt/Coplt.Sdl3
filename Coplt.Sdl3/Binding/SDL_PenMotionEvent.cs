namespace Coplt.Sdl3;

public partial struct SDL_PenMotionEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("SDL_PenID")]
    public uint which;

    [NativeTypeName("SDL_PenInputFlags")]
    public uint pen_state;

    public float x;

    public float y;
}
