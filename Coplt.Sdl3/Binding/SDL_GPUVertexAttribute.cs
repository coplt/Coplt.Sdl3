namespace Coplt.Sdl3;

public partial struct SDL_GPUVertexAttribute
{
    [NativeTypeName("Uint32")]
    public uint location;

    [NativeTypeName("Uint32")]
    public uint buffer_slot;

    public SDL_GPUVertexElementFormat format;

    [NativeTypeName("Uint32")]
    public uint offset;
}
