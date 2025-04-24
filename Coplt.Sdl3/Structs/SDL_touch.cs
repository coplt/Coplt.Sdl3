using System;

namespace Coplt.Sdl3;

public readonly record struct SDL_TouchID(ulong Value);

public readonly record struct SDL_FingerID(ulong Value);
