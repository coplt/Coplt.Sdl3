namespace Coplt.Sdl3;

public partial struct SDL_GPUVertexBufferDescription
{
    [NativeTypeName("Uint32")]
    public uint slot;

    [NativeTypeName("Uint32")]
    public uint pitch;

    public SDL_GPUVertexInputRate input_rate;

    [NativeTypeName("Uint32")]
    public uint instance_step_rate;
}
