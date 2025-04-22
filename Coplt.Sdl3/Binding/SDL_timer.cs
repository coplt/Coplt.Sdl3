using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicks", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong GetTicks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicksNS", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong GetTicksNS();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceCounter", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong GetPerformanceCounter();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceFrequency", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong GetPerformanceFrequency();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Delay", ExactSpelling = true)]
        public static extern void Delay([NativeTypeName("Uint32")] uint ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayNS", ExactSpelling = true)]
        public static extern void DelayNS([NativeTypeName("Uint64")] ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayPrecise", ExactSpelling = true)]
        public static extern void DelayPrecise([NativeTypeName("Uint64")] ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimer", ExactSpelling = true)]
        [return: NativeTypeName("SDL_TimerID")]
        public static extern uint AddTimer([NativeTypeName("Uint32")] uint interval, [NativeTypeName("SDL_TimerCallback")] delegate* unmanaged[Cdecl]<void*, uint, uint, uint> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimerNS", ExactSpelling = true)]
        [return: NativeTypeName("SDL_TimerID")]
        public static extern uint AddTimerNS([NativeTypeName("Uint64")] ulong interval, [NativeTypeName("SDL_NSTimerCallback")] delegate* unmanaged[Cdecl]<void*, uint, ulong, ulong> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveTimer", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);
    }
}
