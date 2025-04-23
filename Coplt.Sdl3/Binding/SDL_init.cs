using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_AppResult
    {
        SDL_APP_CONTINUE,
        SDL_APP_SUCCESS,
        SDL_APP_FAILURE,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Init", ExactSpelling = true)]
        public static extern bool8 Init(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitSubSystem", ExactSpelling = true)]
        public static extern bool8 InitSubSystem(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QuitSubSystem", ExactSpelling = true)]
        public static extern void QuitSubSystem(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WasInit", ExactSpelling = true)]
        public static extern SDL_InitFlags WasInit(SDL_InitFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Quit", ExactSpelling = true)]
        public static extern void Quit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMainThread", ExactSpelling = true)]
        public static extern bool8 IsMainThread();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunOnMainThread", ExactSpelling = true)]
        public static extern bool8 RunOnMainThread(delegate* unmanaged[Cdecl]<void*, void> callback, void* userdata,bool8 wait_complete);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadata", ExactSpelling = true)]
        public static extern bool8 SetAppMetadata(byte* appname,byte* appversion,byte* appidentifier);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadataProperty", ExactSpelling = true)]
        public static extern bool8 SetAppMetadataProperty(byte* name,byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAppMetadataProperty", ExactSpelling = true)]
        public static extern byte* GetAppMetadataProperty(byte* name);
    }
}
