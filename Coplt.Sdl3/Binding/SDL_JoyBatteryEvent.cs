namespace Coplt.Sdl3;

public partial struct SDL_JoyBatteryEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    public SDL_PowerState state;

    public int percent;
}
