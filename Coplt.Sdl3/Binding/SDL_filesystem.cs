using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_Folder
    {
        SDL_FOLDER_HOME,
        SDL_FOLDER_DESKTOP,
        SDL_FOLDER_DOCUMENTS,
        SDL_FOLDER_DOWNLOADS,
        SDL_FOLDER_MUSIC,
        SDL_FOLDER_PICTURES,
        SDL_FOLDER_PUBLICSHARE,
        SDL_FOLDER_SAVEDGAMES,
        SDL_FOLDER_SCREENSHOTS,
        SDL_FOLDER_TEMPLATES,
        SDL_FOLDER_VIDEOS,
        SDL_FOLDER_COUNT,
    }

    public enum SDL_PathType
    {
        SDL_PATHTYPE_NONE,
        SDL_PATHTYPE_FILE,
        SDL_PATHTYPE_DIRECTORY,
        SDL_PATHTYPE_OTHER,
    }

    public partial struct SDL_PathInfo
    {
        public SDL_PathType type;
        public ulong size;
        public long create_time;
        public long modify_time;
        public long access_time;
    }

    public enum SDL_EnumerationResult
    {
        SDL_ENUM_CONTINUE,
        SDL_ENUM_SUCCESS,
        SDL_ENUM_FAILURE,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBasePath", ExactSpelling = true)]
        public static extern byte* GetBasePath();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrefPath", ExactSpelling = true)]
        public static extern byte* GetPrefPath(byte* org,byte* app);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetUserFolder", ExactSpelling = true)]
        public static extern byte* GetUserFolder(SDL_Folder folder);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateDirectory", ExactSpelling = true)]
        public static extern bool8 CreateDirectory(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateDirectory", ExactSpelling = true)]
        public static extern bool8 EnumerateDirectory(byte* path,delegate* unmanaged[Cdecl]<void*, byte*, byte*, SDL_EnumerationResult> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemovePath", ExactSpelling = true)]
        public static extern bool8 RemovePath(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenamePath", ExactSpelling = true)]
        public static extern bool8 RenamePath(byte* oldpath,byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyFile", ExactSpelling = true)]
        public static extern bool8 CopyFile(byte* oldpath,byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPathInfo", ExactSpelling = true)]
        public static extern bool8 GetPathInfo(byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobDirectory", ExactSpelling = true)]
        public static extern byte** GlobDirectory(byte* path,byte* pattern,uint flags, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDirectory", ExactSpelling = true)]
        public static extern byte* GetCurrentDirectory();
    }
}
