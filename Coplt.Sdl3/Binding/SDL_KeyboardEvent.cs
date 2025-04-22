namespace Coplt.Sdl3;

public partial struct SDL_KeyboardEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("SDL_KeyboardID")]
    public uint which;

    public SDL_Scancode scancode;

    [NativeTypeName("SDL_Keycode")]
    public uint key;

    [NativeTypeName("SDL_Keymod")]
    public ushort mod;

    [NativeTypeName("Uint16")]
    public ushort raw;

    [NativeTypeName("_Bool")]
    public byte down;

    [NativeTypeName("_Bool")]
    public byte repeat;
}
