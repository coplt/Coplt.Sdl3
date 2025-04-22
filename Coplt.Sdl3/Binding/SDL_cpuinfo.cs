using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumLogicalCPUCores", ExactSpelling = true)]
        public static extern int GetNumLogicalCPUCores();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCPUCacheLineSize", ExactSpelling = true)]
        public static extern int GetCPUCacheLineSize();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAltiVec", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasAltiVec();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasMMX", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasMMX();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasSSE();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE2", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasSSE2();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE3", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasSSE3();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE41", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasSSE41();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE42", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasSSE42();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasAVX();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX2", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasAVX2();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX512F", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasAVX512F();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasARMSIMD", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasARMSIMD();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasNEON", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasNEON();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLSX", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasLSX();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLASX", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasLASX();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemRAM", ExactSpelling = true)]
        public static extern int GetSystemRAM();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSIMDAlignment", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint GetSIMDAlignment();
    }
}
