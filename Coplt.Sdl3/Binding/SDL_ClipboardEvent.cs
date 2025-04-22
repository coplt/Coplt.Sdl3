namespace Coplt.Sdl3;

public unsafe partial struct SDL_ClipboardEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("_Bool")]
    public byte owner;

    [NativeTypeName("Sint32")]
    public int num_mime_types;

    [NativeTypeName("const char **")]
    public byte** mime_types;
}
