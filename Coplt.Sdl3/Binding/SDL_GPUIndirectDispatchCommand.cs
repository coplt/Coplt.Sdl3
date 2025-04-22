namespace Coplt.Sdl3;

public partial struct SDL_GPUIndirectDispatchCommand
{
    [NativeTypeName("Uint32")]
    public uint groupcount_x;

    [NativeTypeName("Uint32")]
    public uint groupcount_y;

    [NativeTypeName("Uint32")]
    public uint groupcount_z;
}
