namespace Coplt.Sdl3;

public partial struct SDL_GPUDepthStencilState
{
    public SDL_GPUCompareOp compare_op;

    public SDL_GPUStencilOpState back_stencil_state;

    public SDL_GPUStencilOpState front_stencil_state;

    [NativeTypeName("Uint8")]
    public byte compare_mask;

    [NativeTypeName("Uint8")]
    public byte write_mask;

    [NativeTypeName("_Bool")]
    public byte enable_depth_test;

    [NativeTypeName("_Bool")]
    public byte enable_depth_write;

    [NativeTypeName("_Bool")]
    public byte enable_stencil_test;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}
