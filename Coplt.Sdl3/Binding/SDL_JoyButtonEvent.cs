namespace Coplt.Sdl3;

public partial struct SDL_JoyButtonEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte button;

    [NativeTypeName("_Bool")]
    public byte down;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;
}
