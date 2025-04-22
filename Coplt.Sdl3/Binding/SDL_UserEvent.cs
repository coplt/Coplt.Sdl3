namespace Coplt.Sdl3;

public unsafe partial struct SDL_UserEvent
{
    [NativeTypeName("Uint32")]
    public uint type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("Sint32")]
    public int code;

    public void* data1;

    public void* data2;
}
