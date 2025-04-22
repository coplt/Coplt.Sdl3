namespace Coplt.Sdl3;

public partial struct SDL_WindowEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("Sint32")]
    public int data1;

    [NativeTypeName("Sint32")]
    public int data2;
}
