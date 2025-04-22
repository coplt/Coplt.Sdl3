using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public partial struct SDL_PixelFormatDetails
{
    public SDL_PixelFormat format;

    [NativeTypeName("Uint8")]
    public byte bits_per_pixel;

    [NativeTypeName("Uint8")]
    public byte bytes_per_pixel;

    [NativeTypeName("Uint8[2]")]
    public _padding_e__FixedBuffer padding;

    [NativeTypeName("Uint32")]
    public uint Rmask;

    [NativeTypeName("Uint32")]
    public uint Gmask;

    [NativeTypeName("Uint32")]
    public uint Bmask;

    [NativeTypeName("Uint32")]
    public uint Amask;

    [NativeTypeName("Uint8")]
    public byte Rbits;

    [NativeTypeName("Uint8")]
    public byte Gbits;

    [NativeTypeName("Uint8")]
    public byte Bbits;

    [NativeTypeName("Uint8")]
    public byte Abits;

    [NativeTypeName("Uint8")]
    public byte Rshift;

    [NativeTypeName("Uint8")]
    public byte Gshift;

    [NativeTypeName("Uint8")]
    public byte Bshift;

    [NativeTypeName("Uint8")]
    public byte Ashift;

    [InlineArray(2)]
    public partial struct _padding_e__FixedBuffer
    {
        public byte e0;
    }
}
