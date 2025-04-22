namespace Coplt.Sdl3;

public unsafe partial struct SDL_TextInputEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("const char *")]
    public byte* text;
}
