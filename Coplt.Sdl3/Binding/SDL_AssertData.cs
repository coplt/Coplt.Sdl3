namespace Coplt.Sdl3;

public unsafe partial struct SDL_AssertData
{
    [NativeTypeName("_Bool")]
    public byte always_ignore;

    [NativeTypeName("unsigned int")]
    public uint trigger_count;

    [NativeTypeName("const char *")]
    public byte* condition;

    [NativeTypeName("const char *")]
    public byte* filename;

    public int linenum;

    [NativeTypeName("const char *")]
    public byte* function;

    [NativeTypeName("const struct SDL_AssertData *")]
    public SDL_AssertData* next;
}
