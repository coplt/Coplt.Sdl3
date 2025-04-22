namespace Coplt.Sdl3;

public partial struct SDL_GPUMultisampleState
{
    public SDL_GPUSampleCount sample_count;

    [NativeTypeName("Uint32")]
    public uint sample_mask;

    [NativeTypeName("_Bool")]
    public byte enable_mask;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}
