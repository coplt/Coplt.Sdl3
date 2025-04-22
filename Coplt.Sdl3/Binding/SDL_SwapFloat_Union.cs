using System.Runtime.InteropServices;

namespace Coplt.Sdl3;

[StructLayout(LayoutKind.Explicit)]
public partial struct SDL_SwapFloat_Union
{
    [FieldOffset(0)]
    public float f;

    [FieldOffset(0)]
    [NativeTypeName("Uint32")]
    public uint ui32;
}
