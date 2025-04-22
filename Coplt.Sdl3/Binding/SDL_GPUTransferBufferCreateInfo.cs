namespace Coplt.Sdl3;

public partial struct SDL_GPUTransferBufferCreateInfo
{
    public SDL_GPUTransferBufferUsage usage;

    [NativeTypeName("Uint32")]
    public uint size;

    [NativeTypeName("SDL_PropertiesID")]
    public uint props;
}
