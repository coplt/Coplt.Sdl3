using System;

namespace Coplt.Sdl3;

[Flags]
public enum SDL_MessageBoxFlags : uint
{
    Error = 0x00000010u,
    Warning = 0x00000020u,
    Information = 0x00000040u,
    ButtonsLeftToRight = 0x00000080u,
    ButtonsRightToLeft = 0x00000100u,
}

[Flags]
public enum SDL_MessageBoxButtonFlags : uint
{
    ReturnkeyDefault = 0x00000001u,
    EscapekeyDefault = 0x00000002u,
}
