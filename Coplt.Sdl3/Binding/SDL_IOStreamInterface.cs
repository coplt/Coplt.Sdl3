namespace Coplt.Sdl3;

public unsafe partial struct SDL_IOStreamInterface
{
    [NativeTypeName("Uint32")]
    public uint version;

    [NativeTypeName("Sint64 (*)(void *) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, long> size;

    [NativeTypeName("Sint64 (*)(void *, Sint64, SDL_IOWhence) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, long, SDL_IOWhence, long> seek;

    [NativeTypeName("size_t (*)(void *, void *, size_t, SDL_IOStatus *) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, void*, nuint, SDL_IOStatus*, nuint> read;

    [NativeTypeName("size_t (*)(void *, const void *, size_t, SDL_IOStatus *) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, void*, nuint, SDL_IOStatus*, nuint> write;

    [NativeTypeName("_Bool (*)(void *, SDL_IOStatus *) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, SDL_IOStatus*, byte> flush;

    [NativeTypeName("_Bool (*)(void *) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, byte> close;
}
