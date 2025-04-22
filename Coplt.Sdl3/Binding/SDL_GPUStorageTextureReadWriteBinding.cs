namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUStorageTextureReadWriteBinding
{
    public SDL_GPUTexture* texture;

    [NativeTypeName("Uint32")]
    public uint mip_level;

    [NativeTypeName("Uint32")]
    public uint layer;

    [NativeTypeName("_Bool")]
    public byte cycle;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}
