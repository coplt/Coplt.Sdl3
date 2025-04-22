namespace Coplt.Sdl3;

public partial struct SDL_Finger
{
    [NativeTypeName("SDL_FingerID")]
    public ulong id;

    public float x;

    public float y;

    public float pressure;
}
