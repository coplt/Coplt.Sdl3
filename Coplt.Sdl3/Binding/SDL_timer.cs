using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicks", ExactSpelling = true)]
        public static extern ulong GetTicks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicksNS", ExactSpelling = true)]
        public static extern ulong GetTicksNS();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceCounter", ExactSpelling = true)]
        public static extern ulong GetPerformanceCounter();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceFrequency", ExactSpelling = true)]
        public static extern ulong GetPerformanceFrequency();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Delay", ExactSpelling = true)]
        public static extern void Delay(uint ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayNS", ExactSpelling = true)]
        public static extern void DelayNS(ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayPrecise", ExactSpelling = true)]
        public static extern void DelayPrecise(ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimer", ExactSpelling = true)]
        public static extern uint AddTimer(uint interval,delegate* unmanaged[Cdecl]<void*, uint, uint, uint> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimerNS", ExactSpelling = true)]
        public static extern uint AddTimerNS(ulong interval,delegate* unmanaged[Cdecl]<void*, uint, ulong, ulong> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveTimer", ExactSpelling = true)]
        public static extern bool8 RemoveTimer(uint id);
    }
}
