namespace Coplt.Sdl3;

public partial struct SDL_MouseButtonEvent
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

    [NativeTypeName("Uint8")]
    public byte button;

    [NativeTypeName("_Bool")]
    public byte down;

    [NativeTypeName("Uint8")]
    public byte clicks;

    [NativeTypeName("Uint8")]
    public byte padding;

    public float x;

    public float y;
}
