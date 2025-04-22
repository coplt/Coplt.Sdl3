namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUShaderCreateInfo
{
    [NativeTypeName("size_t")]
    public nuint code_size;

    [NativeTypeName("const Uint8 *")]
    public byte* code;

    [NativeTypeName("const char *")]
    public byte* entrypoint;

    [NativeTypeName("SDL_GPUShaderFormat")]
    public uint format;

    public SDL_GPUShaderStage stage;

    [NativeTypeName("Uint32")]
    public uint num_samplers;

    [NativeTypeName("Uint32")]
    public uint num_storage_textures;

    [NativeTypeName("Uint32")]
    public uint num_storage_buffers;

    [NativeTypeName("Uint32")]
    public uint num_uniform_buffers;

    [NativeTypeName("SDL_PropertiesID")]
    public uint props;
}
