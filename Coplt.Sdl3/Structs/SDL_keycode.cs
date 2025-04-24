using System;

namespace Coplt.Sdl3;

public readonly record struct SDL_Keycode(uint Value);

public readonly record struct SDL_Keymod(ushort Value);
