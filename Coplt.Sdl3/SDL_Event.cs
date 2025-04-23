namespace Coplt.Sdl3;

public partial struct SDL_Event
{
    public SDL_EventType Type
    {
        get => (SDL_EventType)type;
        set => type = (uint)value;
    }
}
