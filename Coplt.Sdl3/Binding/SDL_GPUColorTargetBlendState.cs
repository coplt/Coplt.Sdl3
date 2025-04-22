namespace Coplt.Sdl3;

public partial struct SDL_GPUColorTargetBlendState
{
    public SDL_GPUBlendFactor src_color_blendfactor;

    public SDL_GPUBlendFactor dst_color_blendfactor;

    public SDL_GPUBlendOp color_blend_op;

    public SDL_GPUBlendFactor src_alpha_blendfactor;

    public SDL_GPUBlendFactor dst_alpha_blendfactor;

    public SDL_GPUBlendOp alpha_blend_op;

    [NativeTypeName("SDL_GPUColorComponentFlags")]
    public byte color_write_mask;

    [NativeTypeName("_Bool")]
    public byte enable_blend;

    [NativeTypeName("_Bool")]
    public byte enable_color_write_mask;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;
}
