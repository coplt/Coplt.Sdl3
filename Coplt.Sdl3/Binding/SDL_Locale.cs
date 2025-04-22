namespace Coplt.Sdl3;

public unsafe partial struct SDL_Locale
{
    [NativeTypeName("const char *")]
    public byte* language;

    [NativeTypeName("const char *")]
    public byte* country;
}
