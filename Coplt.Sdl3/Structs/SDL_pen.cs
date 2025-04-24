using System;

namespace Coplt.Sdl3;

[Flags]
public enum SDL_PenInputFlags : uint
{
    Down = 1u << 0,
    Button1 = 1u << 1,
    Button2 = 1u << 2,
    Button3 = 1u << 3,
    Button4 = 1u << 4,
    Button5 = 1u << 5,
    EraserTip = 1u << 30,
}

public readonly record struct SDL_PenID(uint Value);
