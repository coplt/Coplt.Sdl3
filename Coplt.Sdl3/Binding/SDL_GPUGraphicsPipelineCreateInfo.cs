namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUGraphicsPipelineCreateInfo
{
    public SDL_GPUShader* vertex_shader;

    public SDL_GPUShader* fragment_shader;

    public SDL_GPUVertexInputState vertex_input_state;

    public SDL_GPUPrimitiveType primitive_type;

    public SDL_GPURasterizerState rasterizer_state;

    public SDL_GPUMultisampleState multisample_state;

    public SDL_GPUDepthStencilState depth_stencil_state;

    public SDL_GPUGraphicsPipelineTargetInfo target_info;

    [NativeTypeName("SDL_PropertiesID")]
    public uint props;
}
