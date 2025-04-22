namespace Coplt.Sdl3;

public unsafe partial struct SDL_TextEditingCandidatesEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("const char *const *")]
    public byte** candidates;

    [NativeTypeName("Sint32")]
    public int num_candidates;

    [NativeTypeName("Sint32")]
    public int selected_candidate;

    [NativeTypeName("_Bool")]
    public byte horizontal;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}
