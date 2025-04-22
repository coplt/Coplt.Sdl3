namespace Coplt.Sdl3;

public partial struct SDL_GPUBufferCreateInfo
{
    [NativeTypeName("SDL_GPUBufferUsageFlags")]
    public uint usage;

    [NativeTypeName("Uint32")]
    public uint size;

    [NativeTypeName("SDL_PropertiesID")]
    public uint props;
}
