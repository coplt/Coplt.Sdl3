namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUBlitRegion
{
    public SDL_GPUTexture* texture;

    [NativeTypeName("Uint32")]
    public uint mip_level;

    [NativeTypeName("Uint32")]
    public uint layer_or_depth_plane;

    [NativeTypeName("Uint32")]
    public uint x;

    [NativeTypeName("Uint32")]
    public uint y;

    [NativeTypeName("Uint32")]
    public uint w;

    [NativeTypeName("Uint32")]
    public uint h;
}
