using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public partial struct SDL_SensorEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_SensorID")]
    public uint which;

    [NativeTypeName("float[6]")]
    public _data_e__FixedBuffer data;

    [NativeTypeName("Uint64")]
    public ulong sensor_timestamp;

    [InlineArray(6)]
    public partial struct _data_e__FixedBuffer
    {
        public float e0;
    }
}
