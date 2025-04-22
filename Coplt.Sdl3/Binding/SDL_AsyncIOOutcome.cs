namespace Coplt.Sdl3;

public unsafe partial struct SDL_AsyncIOOutcome
{
    public SDL_AsyncIO* asyncio;

    public SDL_AsyncIOTaskType type;

    public SDL_AsyncIOResult result;

    public void* buffer;

    [NativeTypeName("Uint64")]
    public ulong offset;

    [NativeTypeName("Uint64")]
    public ulong bytes_requested;

    [NativeTypeName("Uint64")]
    public ulong bytes_transferred;

    public void* userdata;
}
