using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_Locale
    {
        [NativeTypeName("const char *")]
        public byte* language;

        [NativeTypeName("const char *")]
        public byte* country;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPreferredLocales", ExactSpelling = true)]
        public static extern SDL_Locale** GetPreferredLocales(int* count);
    }
}
