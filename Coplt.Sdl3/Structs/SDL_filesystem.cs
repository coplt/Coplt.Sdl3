using System;

namespace Coplt.Sdl3;

[Flags]
public enum SDL_GlobFlags : uint
{
    Caseinsensitive = 1u << 0,
}
