namespace Coplt.Sdl3;

public partial struct SDL_GPUBlitInfo
{
    public SDL_GPUBlitRegion source;

    public SDL_GPUBlitRegion destination;

    public SDL_GPULoadOp load_op;

    public SDL_FColor clear_color;

    public SDL_FlipMode flip_mode;

    public SDL_GPUFilter filter;

    [NativeTypeName("_Bool")]
    public byte cycle;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}
