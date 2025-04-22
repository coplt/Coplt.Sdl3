using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public partial struct SDL_HapticDirection
{
    [NativeTypeName("Uint8")]
    public byte type;

    [NativeTypeName("Sint32[3]")]
    public _dir_e__FixedBuffer dir;

    [InlineArray(3)]
    public partial struct _dir_e__FixedBuffer
    {
        public int e0;
    }
}
