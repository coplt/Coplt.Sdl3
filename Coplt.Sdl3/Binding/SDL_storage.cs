using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_StorageInterface
    {
        [NativeTypeName("Uint32")]
        public uint version;

        [NativeTypeName("_Bool (*)(void *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte> close;

        [NativeTypeName("_Bool (*)(void *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte> ready;

        [NativeTypeName("_Bool (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte*, delegate* unmanaged[Cdecl]<void*, byte*, byte*, SDL_EnumerationResult>, void*, byte> enumerate;

        [NativeTypeName("_Bool (*)(void *, const char *, SDL_PathInfo *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte*, SDL_PathInfo*, byte> info;

        [NativeTypeName("_Bool (*)(void *, const char *, void *, Uint64) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte*, void*, ulong, byte> read_file;

        [NativeTypeName("_Bool (*)(void *, const char *, const void *, Uint64) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte*, void*, ulong, byte> write_file;

        [NativeTypeName("_Bool (*)(void *, const char *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte*, byte> mkdir;

        [NativeTypeName("_Bool (*)(void *, const char *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte*, byte> remove;

        [NativeTypeName("_Bool (*)(void *, const char *, const char *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte> rename;

        [NativeTypeName("_Bool (*)(void *, const char *, const char *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte> copy;

        [NativeTypeName("Uint64 (*)(void *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, ulong> space_remaining;
    }

    public partial struct SDL_Storage
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenTitleStorage", ExactSpelling = true)]
        public static extern SDL_Storage* OpenTitleStorage([NativeTypeName("const char *")] byte* @override, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenUserStorage", ExactSpelling = true)]
        public static extern SDL_Storage* OpenUserStorage([NativeTypeName("const char *")] byte* org, [NativeTypeName("const char *")] byte* app, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenFileStorage", ExactSpelling = true)]
        public static extern SDL_Storage* OpenFileStorage([NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenStorage", ExactSpelling = true)]
        public static extern SDL_Storage* OpenStorage([NativeTypeName("const SDL_StorageInterface *")] SDL_StorageInterface* iface, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseStorage", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte CloseStorage(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StorageReady", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte StorageReady(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageFileSize", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetStorageFileSize(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("Uint64 *")] ulong* length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadStorageFile", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, void* destination, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteStorageFile", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const void *")] void* source, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateStorageDirectory", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte CreateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateStorageDirectory", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte EnumerateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] delegate* unmanaged[Cdecl]<void*, byte*, byte*, SDL_EnumerationResult> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveStoragePath", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte RemoveStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenameStoragePath", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte RenameStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyStorageFile", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte CopyStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStoragePathInfo", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetStoragePathInfo(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageSpaceRemaining", ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong GetStorageSpaceRemaining(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobStorageDirectory", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern byte** GlobStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const char *")] byte* pattern, [NativeTypeName("SDL_GlobFlags")] uint flags, int* count);
    }
}
