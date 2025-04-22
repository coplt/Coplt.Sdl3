namespace Coplt.Sdl3;

public partial struct SDL_DisplayEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_DisplayID")]
    public uint displayID;

    [NativeTypeName("Sint32")]
    public int data1;

    [NativeTypeName("Sint32")]
    public int data2;
}
