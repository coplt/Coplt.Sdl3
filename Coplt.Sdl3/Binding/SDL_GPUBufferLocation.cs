namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUBufferLocation
{
    public SDL_GPUBuffer* buffer;

    [NativeTypeName("Uint32")]
    public uint offset;
}
