using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVersion", ExactSpelling = true)]
        public static extern int GetVersion();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRevision", ExactSpelling = true)]
        public static extern byte* GetRevision();
    }
}
