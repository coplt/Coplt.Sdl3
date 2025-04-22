namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUBufferBinding
{
    public SDL_GPUBuffer* buffer;

    [NativeTypeName("Uint32")]
    public uint offset;
}
