namespace Coplt.Sdl3;

public partial struct SDL_GPURasterizerState
{
    public SDL_GPUFillMode fill_mode;

    public SDL_GPUCullMode cull_mode;

    public SDL_GPUFrontFace front_face;

    public float depth_bias_constant_factor;

    public float depth_bias_clamp;

    public float depth_bias_slope_factor;

    [NativeTypeName("_Bool")]
    public byte enable_depth_bias;

    [NativeTypeName("_Bool")]
    public byte enable_depth_clip;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;
}
