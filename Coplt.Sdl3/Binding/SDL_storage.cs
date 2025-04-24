using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_StorageInterface
    {
        public uint version;
        public delegate* unmanaged[Cdecl]<void*, bool8> close;
        public delegate* unmanaged[Cdecl]<void*, bool8> ready;
        public delegate* unmanaged[Cdecl]<void*, byte*, delegate* unmanaged[Cdecl]<void*, byte*, byte*, SDL_EnumerationResult>, void*, bool8> enumerate;
        public delegate* unmanaged[Cdecl]<void*, byte*, SDL_PathInfo*, bool8> info;
        public delegate* unmanaged[Cdecl]<void*, byte*, void*, ulong, bool8> read_file;
        public delegate* unmanaged[Cdecl]<void*, byte*, void*, ulong, bool8> write_file;
        public delegate* unmanaged[Cdecl]<void*, byte*, bool8> mkdir;
        public delegate* unmanaged[Cdecl]<void*, byte*, bool8> remove;
        public delegate* unmanaged[Cdecl]<void*, byte*, byte*, bool8> rename;
        public delegate* unmanaged[Cdecl]<void*, byte*, byte*, bool8> copy;
        public delegate* unmanaged[Cdecl]<void*, ulong> space_remaining;
    }

    public partial struct SDL_Storage
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenTitleStorage", ExactSpelling = true)]
        public static extern SDL_Storage* OpenTitleStorage(byte* @override, SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenUserStorage", ExactSpelling = true)]
        public static extern SDL_Storage* OpenUserStorage(byte* org,byte* app, SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenFileStorage", ExactSpelling = true)]
        public static extern SDL_Storage* OpenFileStorage(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenStorage", ExactSpelling = true)]
        public static extern SDL_Storage* OpenStorage(SDL_StorageInterface* iface, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseStorage", ExactSpelling = true)]
        public static extern bool8 CloseStorage(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StorageReady", ExactSpelling = true)]
        public static extern bool8 StorageReady(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageFileSize", ExactSpelling = true)]
        public static extern bool8 GetStorageFileSize(SDL_Storage* storage,byte* path,ulong* length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadStorageFile", ExactSpelling = true)]
        public static extern bool8 ReadStorageFile(SDL_Storage* storage,byte* path, void* destination,ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteStorageFile", ExactSpelling = true)]
        public static extern bool8 WriteStorageFile(SDL_Storage* storage,byte* path,void* source,ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateStorageDirectory", ExactSpelling = true)]
        public static extern bool8 CreateStorageDirectory(SDL_Storage* storage,byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateStorageDirectory", ExactSpelling = true)]
        public static extern bool8 EnumerateStorageDirectory(SDL_Storage* storage,byte* path,delegate* unmanaged[Cdecl]<void*, byte*, byte*, SDL_EnumerationResult> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveStoragePath", ExactSpelling = true)]
        public static extern bool8 RemoveStoragePath(SDL_Storage* storage,byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenameStoragePath", ExactSpelling = true)]
        public static extern bool8 RenameStoragePath(SDL_Storage* storage,byte* oldpath,byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyStorageFile", ExactSpelling = true)]
        public static extern bool8 CopyStorageFile(SDL_Storage* storage,byte* oldpath,byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStoragePathInfo", ExactSpelling = true)]
        public static extern bool8 GetStoragePathInfo(SDL_Storage* storage,byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageSpaceRemaining", ExactSpelling = true)]
        public static extern ulong GetStorageSpaceRemaining(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobStorageDirectory", ExactSpelling = true)]
        public static extern byte** GlobStorageDirectory(SDL_Storage* storage,byte* path,byte* pattern, SDL_GlobFlags flags, int* count);
    }
}
