namespace Coplt.Sdl3;

public partial struct SDL_GamepadTouchpadEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Sint32")]
    public int touchpad;

    [NativeTypeName("Sint32")]
    public int finger;

    public float x;

    public float y;

    public float pressure;
}
