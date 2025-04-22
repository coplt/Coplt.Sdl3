using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetError", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetError([NativeTypeName("const char *")] byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetErrorV", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetErrorV([NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OutOfMemory", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 OutOfMemory();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetError", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetError();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearError", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ClearError();
    }
}
