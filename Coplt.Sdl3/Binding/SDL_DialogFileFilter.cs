namespace Coplt.Sdl3;

public unsafe partial struct SDL_DialogFileFilter
{
    [NativeTypeName("const char *")]
    public byte* name;

    [NativeTypeName("const char *")]
    public byte* pattern;
}
