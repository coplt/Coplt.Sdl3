namespace Coplt.Sdl3;

public partial struct SDL_GPUTextureCreateInfo
{
    public SDL_GPUTextureType type;

    public SDL_GPUTextureFormat format;

    [NativeTypeName("SDL_GPUTextureUsageFlags")]
    public uint usage;

    [NativeTypeName("Uint32")]
    public uint width;

    [NativeTypeName("Uint32")]
    public uint height;

    [NativeTypeName("Uint32")]
    public uint layer_count_or_depth;

    [NativeTypeName("Uint32")]
    public uint num_levels;

    public SDL_GPUSampleCount sample_count;

    [NativeTypeName("SDL_PropertiesID")]
    public uint props;
}
