namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUStorageBufferReadWriteBinding
{
    public SDL_GPUBuffer* buffer;

    [NativeTypeName("_Bool")]
    public byte cycle;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}
