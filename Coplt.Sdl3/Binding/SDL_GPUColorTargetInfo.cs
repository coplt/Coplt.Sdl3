namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUColorTargetInfo
{
    public SDL_GPUTexture* texture;

    [NativeTypeName("Uint32")]
    public uint mip_level;

    [NativeTypeName("Uint32")]
    public uint layer_or_depth_plane;

    public SDL_FColor clear_color;

    public SDL_GPULoadOp load_op;

    public SDL_GPUStoreOp store_op;

    public SDL_GPUTexture* resolve_texture;

    [NativeTypeName("Uint32")]
    public uint resolve_mip_level;

    [NativeTypeName("Uint32")]
    public uint resolve_layer;

    [NativeTypeName("_Bool")]
    public byte cycle;

    [NativeTypeName("_Bool")]
    public byte cycle_resolve_texture;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;
}
