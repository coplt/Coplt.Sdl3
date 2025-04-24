using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_PixelType
    {
        Unknown,
        Index1,
        Index4,
        Index8,
        Packed8,
        Packed16,
        Packed32,
        Arrayu8,
        Arrayu16,
        Arrayu32,
        Arrayf16,
        Arrayf32,
        Index2,
    }

    public enum SDL_BitmapOrder
    {
        None,
        _4321,
        _1234,
    }

    public enum SDL_PackedOrder
    {
        None,
        Xrgb,
        Rgbx,
        Argb,
        Rgba,
        Xbgr,
        Bgrx,
        Abgr,
        Bgra,
    }

    public enum SDL_ArrayOrder
    {
        None,
        Rgb,
        Rgba,
        Argb,
        Bgr,
        Bgra,
        Abgr,
    }

    public enum SDL_PackedLayout
    {
        None,
        _332,
        _4444,
        _1555,
        _5551,
        _565,
        _8888,
        _2101010,
        _1010102,
    }

    public enum SDL_PixelFormat : uint
    {
        Unknown = 0,
        Index1lsb = 0x11100100U,
        Index1msb = 0x11200100U,
        Index2lsb = 0x1c100200U,
        Index2msb = 0x1c200200U,
        Index4lsb = 0x12100400U,
        Index4msb = 0x12200400U,
        Index8 = 0x13000801U,
        Rgb332 = 0x14110801U,
        Xrgb4444 = 0x15120c02U,
        Xbgr4444 = 0x15520c02U,
        Xrgb1555 = 0x15130f02U,
        Xbgr1555 = 0x15530f02U,
        Argb4444 = 0x15321002U,
        Rgba4444 = 0x15421002U,
        Abgr4444 = 0x15721002U,
        Bgra4444 = 0x15821002U,
        Argb1555 = 0x15331002U,
        Rgba5551 = 0x15441002U,
        Abgr1555 = 0x15731002U,
        Bgra5551 = 0x15841002U,
        Rgb565 = 0x15151002U,
        Bgr565 = 0x15551002U,
        Rgb24 = 0x17101803U,
        Bgr24 = 0x17401803U,
        Xrgb8888 = 0x16161804U,
        Rgbx8888 = 0x16261804U,
        Xbgr8888 = 0x16561804U,
        Bgrx8888 = 0x16661804U,
        Argb8888 = 0x16362004U,
        Rgba8888 = 0x16462004U,
        Abgr8888 = 0x16762004U,
        Bgra8888 = 0x16862004U,
        Xrgb2101010 = 0x16172004U,
        Xbgr2101010 = 0x16572004U,
        Argb2101010 = 0x16372004U,
        Abgr2101010 = 0x16772004U,
        Rgb48 = 0x18103006U,
        Bgr48 = 0x18403006U,
        Rgba64 = 0x18204008U,
        Argb64 = 0x18304008U,
        Bgra64 = 0x18504008U,
        Abgr64 = 0x18604008U,
        Rgb48Float = 0x1a103006U,
        Bgr48Float = 0x1a403006U,
        Rgba64Float = 0x1a204008U,
        Argb64Float = 0x1a304008U,
        Bgra64Float = 0x1a504008U,
        Abgr64Float = 0x1a604008U,
        Rgb96Float = 0x1b10600cU,
        Bgr96Float = 0x1b40600cU,
        Rgba128Float = 0x1b208010U,
        Argb128Float = 0x1b308010U,
        Bgra128Float = 0x1b508010U,
        Abgr128Float = 0x1b608010U,
        Yv12 = 0x32315659U,
        Iyuv = 0x56555949U,
        Yuy2 = 0x32595559U,
        Uyvy = 0x59565955U,
        Yvyu = 0x55595659U,
        Nv12 = 0x3231564eU,
        Nv21 = 0x3132564eU,
        P010 = 0x30313050U,
        ExternalOes = 0x2053454fU,
        Mjpg = 0x47504a4dU,
        Rgba32 = Abgr8888,
        Argb32 = Bgra8888,
        Bgra32 = Argb8888,
        Abgr32 = Rgba8888,
        Rgbx32 = Xbgr8888,
        Xrgb32 = Bgrx8888,
        Bgrx32 = Xrgb8888,
        Xbgr32 = Rgbx8888,
    }

    public enum SDL_ColorType
    {
        TypeUnknown = 0,
        TypeRgb = 1,
        TypeYcbcr = 2,
    }

    public enum SDL_ColorRange
    {
        RangeUnknown = 0,
        RangeLimited = 1,
        RangeFull = 2,
    }

    public enum SDL_ColorPrimaries
    {
        PrimariesUnknown = 0,
        PrimariesBt709 = 1,
        PrimariesUnspecified = 2,
        PrimariesBt470m = 4,
        PrimariesBt470bg = 5,
        PrimariesBt601 = 6,
        PrimariesSmpte240 = 7,
        PrimariesGenericFilm = 8,
        PrimariesBt2020 = 9,
        PrimariesXyz = 10,
        PrimariesSmpte431 = 11,
        PrimariesSmpte432 = 12,
        PrimariesEbu3213 = 22,
        PrimariesCustom = 31,
    }

    public enum SDL_TransferCharacteristics
    {
        CharacteristicsUnknown = 0,
        CharacteristicsBt709 = 1,
        CharacteristicsUnspecified = 2,
        CharacteristicsGamma22 = 4,
        CharacteristicsGamma28 = 5,
        CharacteristicsBt601 = 6,
        CharacteristicsSmpte240 = 7,
        CharacteristicsLinear = 8,
        CharacteristicsLog100 = 9,
        CharacteristicsLog100Sqrt10 = 10,
        CharacteristicsIec61966 = 11,
        CharacteristicsBt1361 = 12,
        CharacteristicsSrgb = 13,
        CharacteristicsBt2020_10bit = 14,
        CharacteristicsBt2020_12bit = 15,
        CharacteristicsPq = 16,
        CharacteristicsSmpte428 = 17,
        CharacteristicsHlg = 18,
        CharacteristicsCustom = 31,
    }

    public enum SDL_MatrixCoefficients
    {
        CoefficientsIdentity = 0,
        CoefficientsBt709 = 1,
        CoefficientsUnspecified = 2,
        CoefficientsFcc = 4,
        CoefficientsBt470bg = 5,
        CoefficientsBt601 = 6,
        CoefficientsSmpte240 = 7,
        CoefficientsYcgco = 8,
        CoefficientsBt2020Ncl = 9,
        CoefficientsBt2020Cl = 10,
        CoefficientsSmpte2085 = 11,
        CoefficientsChromaDerivedNcl = 12,
        CoefficientsChromaDerivedCl = 13,
        CoefficientsIctcp = 14,
        CoefficientsCustom = 31,
    }

    public enum SDL_ChromaLocation
    {
        LocationNone = 0,
        LocationLeft = 1,
        LocationCenter = 2,
        LocationTopleft = 3,
    }

    public enum SDL_Colorspace : uint
    {
        Unknown = 0,
        Srgb = 0x120005a0U,
        SrgbLinear = 0x12000500U,
        Hdr10 = 0x12002600U,
        Jpeg = 0x220004c6U,
        Bt601Limited = 0x211018c6U,
        Bt601Full = 0x221018c6U,
        Bt709Limited = 0x21100421U,
        Bt709Full = 0x22100421U,
        Bt2020Limited = 0x21102609U,
        Bt2020Full = 0x22102609U,
        RgbDefault = Srgb,
        YuvDefault = Jpeg,
    }

    public partial struct SDL_Color
    {
        public byte r;
        public byte g;
        public byte b;
        public byte a;
    }

    public partial struct SDL_FColor
    {
        public float r;

        public float g;

        public float b;

        public float a;
    }

    public unsafe partial struct SDL_Palette
    {
        public int ncolors;

        public SDL_Color* colors;
        public uint version;

        public int refcount;
    }

    public partial struct SDL_PixelFormatDetails
    {
        public SDL_PixelFormat format;
        public byte bits_per_pixel;
        public byte bytes_per_pixel;
        public _padding_e__FixedBuffer padding;
        public uint Rmask;
        public uint Gmask;
        public uint Bmask;
        public uint Amask;
        public byte Rbits;
        public byte Gbits;
        public byte Bbits;
        public byte Abits;
        public byte Rshift;
        public byte Gshift;
        public byte Bshift;
        public byte Ashift;

        [InlineArray(2)]
        public partial struct _padding_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatName", ExactSpelling = true)]
        public static extern byte* GetPixelFormatName(SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMasksForPixelFormat", ExactSpelling = true)]
        public static extern bool8 GetMasksForPixelFormat(SDL_PixelFormat format, int* bpp,uint* Rmask,uint* Gmask,uint* Bmask,uint* Amask);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatForMasks", ExactSpelling = true)]
        public static extern SDL_PixelFormat GetPixelFormatForMasks(int bpp,uint Rmask,uint Gmask,uint Bmask,uint Amask);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatDetails", ExactSpelling = true)]
        public static extern SDL_PixelFormatDetails* GetPixelFormatDetails(SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreatePalette", ExactSpelling = true)]
        public static extern SDL_Palette* CreatePalette(int ncolors);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPaletteColors", ExactSpelling = true)]
        public static extern bool8 SetPaletteColors(SDL_Palette* palette,SDL_Color* colors, int firstcolor, int ncolors);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyPalette", ExactSpelling = true)]
        public static extern void DestroyPalette(SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapRGB", ExactSpelling = true)]
        public static extern uint MapRGB(SDL_PixelFormatDetails* format,SDL_Palette* palette,byte r,byte g,byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapRGBA", ExactSpelling = true)]
        public static extern uint MapRGBA(SDL_PixelFormatDetails* format,SDL_Palette* palette,byte r,byte g,byte b,byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRGB", ExactSpelling = true)]
        public static extern void GetRGB(uint pixel,SDL_PixelFormatDetails* format,SDL_Palette* palette,byte* r,byte* g,byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRGBA", ExactSpelling = true)]
        public static extern void GetRGBA(uint pixel,SDL_PixelFormatDetails* format,SDL_Palette* palette,byte* r,byte* g,byte* b,byte* a);
    }
}
