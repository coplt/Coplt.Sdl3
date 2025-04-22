namespace Coplt.Sdl3;

public partial struct SDL_GPUSamplerCreateInfo
{
    public SDL_GPUFilter min_filter;

    public SDL_GPUFilter mag_filter;

    public SDL_GPUSamplerMipmapMode mipmap_mode;

    public SDL_GPUSamplerAddressMode address_mode_u;

    public SDL_GPUSamplerAddressMode address_mode_v;

    public SDL_GPUSamplerAddressMode address_mode_w;

    public float mip_lod_bias;

    public float max_anisotropy;

    public SDL_GPUCompareOp compare_op;

    public float min_lod;

    public float max_lod;

    [NativeTypeName("_Bool")]
    public byte enable_anisotropy;

    [NativeTypeName("_Bool")]
    public byte enable_compare;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("SDL_PropertiesID")]
    public uint props;
}
