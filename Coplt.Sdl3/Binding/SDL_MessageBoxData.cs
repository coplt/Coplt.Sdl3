namespace Coplt.Sdl3;

public unsafe partial struct SDL_MessageBoxData
{
    [NativeTypeName("SDL_MessageBoxFlags")]
    public uint flags;

    public SDL_Window* window;

    [NativeTypeName("const char *")]
    public byte* title;

    [NativeTypeName("const char *")]
    public byte* message;

    public int numbuttons;

    [NativeTypeName("const SDL_MessageBoxButtonData *")]
    public SDL_MessageBoxButtonData* buttons;

    [NativeTypeName("const SDL_MessageBoxColorScheme *")]
    public SDL_MessageBoxColorScheme* colorScheme;
}
