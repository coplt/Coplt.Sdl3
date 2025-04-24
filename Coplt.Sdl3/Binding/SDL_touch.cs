using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_TouchDeviceType
    {
        Invalid = -1,
        Direct,
        IndirectAbsolute,
        IndirectRelative,
    }

    public partial struct SDL_Finger
    {
        public SDL_FingerID id;

        public float x;

        public float y;

        public float pressure;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDevices", ExactSpelling = true)]
        public static extern SDL_TouchID* GetTouchDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceName", ExactSpelling = true)]
        public static extern byte* GetTouchDeviceName(SDL_TouchID touchID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceType", ExactSpelling = true)]
        public static extern SDL_TouchDeviceType GetTouchDeviceType(SDL_TouchID touchID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchFingers", ExactSpelling = true)]
        public static extern SDL_Finger** GetTouchFingers(SDL_TouchID touchID, int* count);
    }
}
