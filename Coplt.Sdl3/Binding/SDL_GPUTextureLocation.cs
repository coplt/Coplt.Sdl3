namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUTextureLocation
{
    public SDL_GPUTexture* texture;

    [NativeTypeName("Uint32")]
    public uint mip_level;

    [NativeTypeName("Uint32")]
    public uint layer;

    [NativeTypeName("Uint32")]
    public uint x;

    [NativeTypeName("Uint32")]
    public uint y;

    [NativeTypeName("Uint32")]
    public uint z;
}
