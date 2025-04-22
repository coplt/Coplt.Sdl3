namespace Coplt.Sdl3;

public partial struct SDL_AudioDeviceEvent
{
    public SDL_EventType type;

    [NativeTypeName("Uint32")]
    public uint reserved;

    [NativeTypeName("Uint64")]
    public ulong timestamp;

    [NativeTypeName("SDL_AudioDeviceID")]
    public uint which;

    [NativeTypeName("_Bool")]
    public byte recording;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}
