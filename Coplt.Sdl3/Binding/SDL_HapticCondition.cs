using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public partial struct SDL_HapticCondition
{
    [NativeTypeName("Uint16")]
    public ushort type;

    public SDL_HapticDirection direction;

    [NativeTypeName("Uint32")]
    public uint length;

    [NativeTypeName("Uint16")]
    public ushort delay;

    [NativeTypeName("Uint16")]
    public ushort button;

    [NativeTypeName("Uint16")]
    public ushort interval;

    [NativeTypeName("Uint16[3]")]
    public _right_sat_e__FixedBuffer right_sat;

    [NativeTypeName("Uint16[3]")]
    public _left_sat_e__FixedBuffer left_sat;

    [NativeTypeName("Sint16[3]")]
    public _right_coeff_e__FixedBuffer right_coeff;

    [NativeTypeName("Sint16[3]")]
    public _left_coeff_e__FixedBuffer left_coeff;

    [NativeTypeName("Uint16[3]")]
    public _deadband_e__FixedBuffer deadband;

    [NativeTypeName("Sint16[3]")]
    public _center_e__FixedBuffer center;

    [InlineArray(3)]
    public partial struct _right_sat_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(3)]
    public partial struct _left_sat_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(3)]
    public partial struct _right_coeff_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(3)]
    public partial struct _left_coeff_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(3)]
    public partial struct _deadband_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(3)]
    public partial struct _center_e__FixedBuffer
    {
        public short e0;
    }
}
