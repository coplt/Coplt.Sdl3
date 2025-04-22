namespace Coplt.Sdl3;

public partial struct SDL_GPUIndirectDrawCommand
{
    [NativeTypeName("Uint32")]
    public uint num_vertices;

    [NativeTypeName("Uint32")]
    public uint num_instances;

    [NativeTypeName("Uint32")]
    public uint first_vertex;

    [NativeTypeName("Uint32")]
    public uint first_instance;
}
