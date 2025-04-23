using System;

namespace Coplt.Sdl3;

public enum SDL_MouseButton
{
    None = 0,
    Left = 1,
    Middle = 2,
    Right = 3,
    X1 = 4,
    X2 = 5,
}

[Flags]
public enum SDL_MouseButtonFlags : uint
{
    Left = 1 << 0,
    Middle = 1 << 1,
    Right = 1 << 2,
    X1 = 1 << 3,
    X2 = 1 << 4,
}
