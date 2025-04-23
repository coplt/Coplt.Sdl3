using System;

namespace Coplt.Sdl3;

[Flags]
public enum SDL_SurfaceFlags : uint
{
    Preallocated = 0x00000001u,
    LockNeeded = 0x00000002u,
    Locked = 0x00000004u,
    SimdAligned = 0x00000008u,
}
