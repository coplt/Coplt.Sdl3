using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_DialogFileFilter
    {
        public byte* name;
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
        public static extern void ShowOpenFileDialog(delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window,SDL_DialogFileFilter* filters, int nfilters,byte* default_location,bool8 allow_many);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSaveFileDialog", ExactSpelling = true)]
        public static extern void ShowSaveFileDialog(delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window,SDL_DialogFileFilter* filters, int nfilters,byte* default_location);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowOpenFolderDialog", ExactSpelling = true)]
        public static extern void ShowOpenFolderDialog(delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window,byte* default_location,bool8 allow_many);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowFileDialogWithProperties", ExactSpelling = true)]
        public static extern void ShowFileDialogWithProperties(SDL_FileDialogType type,delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata,uint props);
    }
}
