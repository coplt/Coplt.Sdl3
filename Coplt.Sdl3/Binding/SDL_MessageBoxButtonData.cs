namespace Coplt.Sdl3;

public unsafe partial struct SDL_MessageBoxButtonData
{
    [NativeTypeName("SDL_MessageBoxButtonFlags")]
    public uint flags;

    public int buttonID;

    [NativeTypeName("const char *")]
    public byte* text;
}
