using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public partial struct SDL_GamepadSensorEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Sint32")]
    public int sensor;

    [NativeTypeName("float[3]")]
    public _data_e__FixedBuffer data;

    [NativeTypeName("Uint64")]
    public ulong sensor_timestamp;

    [InlineArray(3)]
    public partial struct _data_e__FixedBuffer
    {
        public float e0;
    }
}
