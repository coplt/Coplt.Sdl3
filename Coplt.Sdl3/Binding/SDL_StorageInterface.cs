namespace Coplt.Sdl3;

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
