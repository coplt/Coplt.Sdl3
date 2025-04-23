using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenURL", ExactSpelling = true)]
        public static extern bool8 OpenURL(byte* url);
    }
}
