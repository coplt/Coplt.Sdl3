using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_CreateView", ExactSpelling = true)]
        public static extern void* Metal_CreateView(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_DestroyView", ExactSpelling = true)]
        public static extern void Metal_DestroyView(void* view);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_GetLayer", ExactSpelling = true)]
        public static extern void* Metal_GetLayer(void* view);
    }
}
