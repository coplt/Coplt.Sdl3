using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_PowerState
    {
        Error = -1,
        Unknown,
        OnBattery,
        NoBattery,
        Charging,
        Charged,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPowerInfo", ExactSpelling = true)]
        public static extern SDL_PowerState GetPowerInfo(int* seconds, int* percent);
    }
}
