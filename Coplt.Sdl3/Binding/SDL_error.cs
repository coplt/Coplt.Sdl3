using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetError", ExactSpelling = true)]
        public static extern bool8 SetError(byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetErrorV", ExactSpelling = true)]
        public static extern bool8 SetErrorV(byte* fmt,byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OutOfMemory", ExactSpelling = true)]
        public static extern bool8 OutOfMemory();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetError", ExactSpelling = true)]
        public static extern byte* GetError();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearError", ExactSpelling = true)]
        public static extern bool8 ClearError();
    }
}
