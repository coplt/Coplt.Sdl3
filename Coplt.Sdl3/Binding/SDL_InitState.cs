namespace Coplt.Sdl3;

public unsafe partial struct SDL_InitState
{
    public SDL_AtomicInt status;

    [NativeTypeName("SDL_ThreadID")]
    public ulong thread;

    public void* reserved;
}
