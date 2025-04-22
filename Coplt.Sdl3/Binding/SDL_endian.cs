using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_SwapFloat_Union
    {
        [FieldOffset(0)]
        public float f;

        [FieldOffset(0)]
        [NativeTypeName("Uint32")]
        public uint ui32;
    }

    public static partial class SDL
    {
        public static float SwapFloat(float x)
        {
            SDL_SwapFloat_Union swapper;

            swapper.ui32 = 0;
            swapper.f = x;
            swapper.ui32 = __builtin_bswap32(swapper.ui32);
            return swapper.f;
        }
    }
}
