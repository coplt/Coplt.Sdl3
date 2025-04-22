namespace Coplt.Sdl3;

public unsafe partial struct SDL_GPUVertexInputState
{
    [NativeTypeName("const SDL_GPUVertexBufferDescription *")]
    public SDL_GPUVertexBufferDescription* vertex_buffer_descriptions;

    [NativeTypeName("Uint32")]
    public uint num_vertex_buffers;

    [NativeTypeName("const SDL_GPUVertexAttribute *")]
    public SDL_GPUVertexAttribute* vertex_attributes;

    [NativeTypeName("Uint32")]
    public uint num_vertex_attributes;
}
