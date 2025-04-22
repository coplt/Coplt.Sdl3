namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUGraphicsPipelineTargetInfo
{
    [NativeTypeName("const SDL_GPUColorTargetDescription *")]
    public SDL_GPUColorTargetDescription* color_target_descriptions;

    [NativeTypeName("Uint32")]
    public uint num_color_targets;

    public SDL_GPUTextureFormat depth_stencil_format;

    [NativeTypeName("_Bool")]
    public byte has_depth_stencil_target;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}
