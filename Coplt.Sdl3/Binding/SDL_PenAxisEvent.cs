namespace Coplt.Sdl3;

public partial struct SDL_PenAxisEvent
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

    public SDL_PenAxis axis;

    public float value;
}
