namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUComputePipelineCreateInfo
{
    [NativeTypeName("size_t")]
    public nuint code_size;

    [NativeTypeName("const Uint8 *")]
    public byte* code;

    [NativeTypeName("const char *")]
    public byte* entrypoint;

    [NativeTypeName("SDL_GPUShaderFormat")]
    public uint format;

    [NativeTypeName("Uint32")]
    public uint num_samplers;

    [NativeTypeName("Uint32")]
    public uint num_readonly_storage_textures;

    [NativeTypeName("Uint32")]
    public uint num_readonly_storage_buffers;

    [NativeTypeName("Uint32")]
    public uint num_readwrite_storage_textures;

    [NativeTypeName("Uint32")]
    public uint num_readwrite_storage_buffers;

    [NativeTypeName("Uint32")]
    public uint num_uniform_buffers;

    [NativeTypeName("Uint32")]
    public uint threadcount_x;

    [NativeTypeName("Uint32")]
    public uint threadcount_y;

    [NativeTypeName("Uint32")]
    public uint threadcount_z;

    [NativeTypeName("SDL_PropertiesID")]
    public uint props;
}
