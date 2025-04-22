using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public partial struct SDL_GUID
{
    [NativeTypeName("Uint8[16]")]
    public _data_e__FixedBuffer data;

    [InlineArray(16)]
    public partial struct _data_e__FixedBuffer
    {
        public byte e0;
    }
}
