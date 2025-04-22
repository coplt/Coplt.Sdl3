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
        [return: NativeTypeName("_Bool")]
        public static extern bool8 Init([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitSubSystem", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 InitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QuitSubSystem", ExactSpelling = true)]
        public static extern void QuitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WasInit", ExactSpelling = true)]
        [return: NativeTypeName("SDL_InitFlags")]
        public static extern uint WasInit([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Quit", ExactSpelling = true)]
        public static extern void Quit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMainThread", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 IsMainThread();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunOnMainThread", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RunOnMainThread([NativeTypeName("SDL_MainThreadCallback")] delegate* unmanaged[Cdecl]<void*, void> callback, void* userdata, [NativeTypeName("_Bool")] bool8 wait_complete);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadata", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAppMetadata([NativeTypeName("const char *")] byte* appname, [NativeTypeName("const char *")] byte* appversion, [NativeTypeName("const char *")] byte* appidentifier);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadataProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAppMetadataProperty([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAppMetadataProperty", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetAppMetadataProperty([NativeTypeName("const char *")] byte* name);
    }
}
