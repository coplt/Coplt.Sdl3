namespace Coplt.Sdl3;

public partial struct SDL_JoyAxisEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte axis;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;

    [NativeTypeName("Sint16")]
    public short value;

    [NativeTypeName("Uint16")]
    public ushort padding4;
}
