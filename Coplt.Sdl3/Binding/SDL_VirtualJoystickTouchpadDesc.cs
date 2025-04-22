using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public partial struct SDL_VirtualJoystickTouchpadDesc
{
    [NativeTypeName("Uint16")]
    public ushort nfingers;

    [NativeTypeName("Uint16[3]")]
    public _padding_e__FixedBuffer padding;

    [InlineArray(3)]
    public partial struct _padding_e__FixedBuffer
    {
        public ushort e0;
    }
}
