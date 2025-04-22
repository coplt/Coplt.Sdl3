namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPURenderStateDesc
{
    [NativeTypeName("Uint32")]
    public uint version;

    public SDL_GPUShader* fragment_shader;

    [NativeTypeName("Sint32")]
    public int num_sampler_bindings;

    [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
    public SDL_GPUTextureSamplerBinding* sampler_bindings;

    [NativeTypeName("Sint32")]
    public int num_storage_textures;

    [NativeTypeName("SDL_GPUTexture *const *")]
    public SDL_GPUTexture** storage_textures;

    [NativeTypeName("Sint32")]
    public int num_storage_buffers;

    [NativeTypeName("SDL_GPUBuffer *const *")]
    public SDL_GPUBuffer** storage_buffers;
}
