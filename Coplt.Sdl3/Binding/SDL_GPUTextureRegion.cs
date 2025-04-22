namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUTextureRegion
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

    [NativeTypeName("Uint32")]
    public uint w;

    [NativeTypeName("Uint32")]
    public uint h;

    [NativeTypeName("Uint32")]
    public uint d;
}
