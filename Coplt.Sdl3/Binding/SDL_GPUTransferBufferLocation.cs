namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUTransferBufferLocation
{
    public SDL_GPUTransferBuffer* transfer_buffer;

    [NativeTypeName("Uint32")]
    public uint offset;
}
