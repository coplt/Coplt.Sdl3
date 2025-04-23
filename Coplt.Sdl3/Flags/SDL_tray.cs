using System;

namespace Coplt.Sdl3;

[Flags]
public enum SDL_TrayEntryFlags : uint
{
    Button = 0x00000001u,
    Checkbox = 0x00000002u,
    Submenu = 0x00000004u,
    Disabled = 0x80000000u,
    Checked = 0x40000000u,
}
