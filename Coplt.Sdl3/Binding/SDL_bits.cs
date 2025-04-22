namespace Coplt.Sdl3
{
    public static partial class SDL
    {
        public static int MostSignificantBitIndex32([NativeTypeName("Uint32")] uint x)
        {
            if (x == 0)
            {
                return -1;
            }

            return 31 - __builtin_clz(x);
        }

        [return: NativeTypeName("_Bool")]
        public static bool8 HasExactlyOneBitSet32([NativeTypeName("Uint32")] uint x)
        {
            if ((x != 0) && (x & (x - 1)) == 0)
            {
                return (1) != 0;
            }

            return (0) != 0;
        }
    }
}
