using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_Folder
    {
        Home,
        Desktop,
        Documents,
        Downloads,
        Music,
        Pictures,
        Publicshare,
        Savedgames,
        Screenshots,
        Templates,
        Videos,
        Count,
    }

    public enum SDL_PathType
    {
        None,
        File,
        Directory,
        Other,
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
        Continue,
        Success,
        Failure,
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
        public static extern byte** GlobDirectory(byte* path,byte* pattern, SDL_GlobFlags flags, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDirectory", ExactSpelling = true)]
        public static extern byte* GetCurrentDirectory();
    }
}
