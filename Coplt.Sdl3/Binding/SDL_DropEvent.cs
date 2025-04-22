namespace Coplt.Sdl3;

public unsafe partial struct SDL_DropEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    public float x;

    public float y;

    [NativeTypeName("const char *")]
    public byte* source;

    [NativeTypeName("const char *")]
    public byte* data;
}
