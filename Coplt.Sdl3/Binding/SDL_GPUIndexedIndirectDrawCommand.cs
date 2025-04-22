namespace Coplt.Sdl3;

public partial struct SDL_GPUIndexedIndirectDrawCommand
{
    [NativeTypeName("Uint32")]
    public uint num_indices;

    [NativeTypeName("Uint32")]
    public uint num_instances;

    [NativeTypeName("Uint32")]
    public uint first_index;

    [NativeTypeName("Sint32")]
    public int vertex_offset;

    [NativeTypeName("Uint32")]
    public uint first_instance;
}
