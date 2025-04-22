using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public partial struct SDL_MessageBoxColorScheme
{
    [NativeTypeName("SDL_MessageBoxColor[5]")]
    public _colors_e__FixedBuffer colors;

    [InlineArray(5)]
    public partial struct _colors_e__FixedBuffer
    {
        public SDL_MessageBoxColor e0;
    }
}
