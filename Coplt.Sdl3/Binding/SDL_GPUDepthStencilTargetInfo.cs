namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUDepthStencilTargetInfo
{
    public SDL_GPUTexture* texture;

    public float clear_depth;

    public SDL_GPULoadOp load_op;

    public SDL_GPUStoreOp store_op;

    public SDL_GPULoadOp stencil_load_op;

    public SDL_GPUStoreOp stencil_store_op;

    [NativeTypeName("_Bool")]
    public byte cycle;

    [NativeTypeName("Uint8")]
    public byte clear_stencil;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;
}
