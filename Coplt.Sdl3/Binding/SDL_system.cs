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
        SDL_SANDBOX_NONE = 0,
        SDL_SANDBOX_UNKNOWN_CONTAINER,
        SDL_SANDBOX_FLATPAK,
        SDL_SANDBOX_SNAP,
        SDL_SANDBOX_MACOS,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowsMessageHook", ExactSpelling = true)]
        public static extern void SetWindowsMessageHook([NativeTypeName("SDL_WindowsMessageHook")] delegate* unmanaged[Cdecl]<void*, tagMSG*, bool8> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDirect3D9AdapterIndex", ExactSpelling = true)]
        public static extern int GetDirect3D9AdapterIndex([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDXGIOutputInfo", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetDXGIOutputInfo([NativeTypeName("SDL_DisplayID")] uint displayID, int* adapterIndex, int* outputIndex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetX11EventHook", ExactSpelling = true)]
        public static extern void SetX11EventHook([NativeTypeName("SDL_X11EventHook")] delegate* unmanaged[Cdecl]<void*, _XEvent*, bool8> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTablet", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 IsTablet();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTV", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
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
