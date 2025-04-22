namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUBufferRegion
{
    public SDL_GPUBuffer* buffer;

    [NativeTypeName("Uint32")]
    public uint offset;

    [NativeTypeName("Uint32")]
    public uint size;
}
