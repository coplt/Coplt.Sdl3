using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct tagMSG
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _XEvent
    {
    }

    public enum SDL_Sandbox
    {
        None = 0,
        UnknownContainer,
        Flatpak,
        Snap,
        Macos,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowsMessageHook", ExactSpelling = true)]
        public static extern void SetWindowsMessageHook(delegate* unmanaged[Cdecl]<void*, tagMSG*, bool8> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDirect3D9AdapterIndex", ExactSpelling = true)]
        public static extern int GetDirect3D9AdapterIndex(SDL_DisplayID displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDXGIOutputInfo", ExactSpelling = true)]
        public static extern bool8 GetDXGIOutputInfo(SDL_DisplayID displayID, int* adapterIndex, int* outputIndex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetX11EventHook", ExactSpelling = true)]
        public static extern void SetX11EventHook(delegate* unmanaged[Cdecl]<void*, _XEvent*, bool8> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTablet", ExactSpelling = true)]
        public static extern bool8 IsTablet();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTV", ExactSpelling = true)]
        public static extern bool8 IsTV();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSandbox", ExactSpelling = true)]
        public static extern SDL_Sandbox GetSandbox();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillTerminate", ExactSpelling = true)]
        public static extern void OnApplicationWillTerminate();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning", ExactSpelling = true)]
        public static extern void OnApplicationDidReceiveMemoryWarning();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillEnterBackground", ExactSpelling = true)]
        public static extern void OnApplicationWillEnterBackground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidEnterBackground", ExactSpelling = true)]
        public static extern void OnApplicationDidEnterBackground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillEnterForeground", ExactSpelling = true)]
        public static extern void OnApplicationWillEnterForeground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidEnterForeground", ExactSpelling = true)]
        public static extern void OnApplicationDidEnterForeground();
    }
}
