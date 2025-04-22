namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUTextureTransferInfo
{
    public SDL_GPUTransferBuffer* transfer_buffer;

    [NativeTypeName("Uint32")]
    public uint offset;

    [NativeTypeName("Uint32")]
    public uint pixels_per_row;

    [NativeTypeName("Uint32")]
    public uint rows_per_layer;
}
