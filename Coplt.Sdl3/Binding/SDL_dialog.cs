using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_DialogFileFilter
    {
        [NativeTypeName("const char *")]
        public byte* name;

        [NativeTypeName("const char *")]
        public byte* pattern;
    }

    public enum SDL_FileDialogType
    {
        SDL_FILEDIALOG_OPENFILE,
        SDL_FILEDIALOG_SAVEFILE,
        SDL_FILEDIALOG_OPENFOLDER,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowOpenFileDialog", ExactSpelling = true)]
        public static extern void ShowOpenFileDialog([NativeTypeName("SDL_DialogFileCallback")] delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window, [NativeTypeName("const SDL_DialogFileFilter *")] SDL_DialogFileFilter* filters, int nfilters, [NativeTypeName("const char *")] byte* default_location, [NativeTypeName("_Bool")] byte allow_many);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSaveFileDialog", ExactSpelling = true)]
        public static extern void ShowSaveFileDialog([NativeTypeName("SDL_DialogFileCallback")] delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window, [NativeTypeName("const SDL_DialogFileFilter *")] SDL_DialogFileFilter* filters, int nfilters, [NativeTypeName("const char *")] byte* default_location);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowOpenFolderDialog", ExactSpelling = true)]
        public static extern void ShowOpenFolderDialog([NativeTypeName("SDL_DialogFileCallback")] delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window, [NativeTypeName("const char *")] byte* default_location, [NativeTypeName("_Bool")] byte allow_many);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowFileDialogWithProperties", ExactSpelling = true)]
        public static extern void ShowFileDialogWithProperties(SDL_FileDialogType type, [NativeTypeName("SDL_DialogFileCallback")] delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, [NativeTypeName("SDL_PropertiesID")] uint props);
    }
}
