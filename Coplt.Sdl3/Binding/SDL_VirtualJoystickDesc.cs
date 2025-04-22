using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public unsafe partial struct SDL_VirtualJoystickDesc
{
    [NativeTypeName("Uint32")]
    public uint version;

    [NativeTypeName("Uint16")]
    public ushort type;

    [NativeTypeName("Uint16")]
    public ushort padding;

    [NativeTypeName("Uint16")]
    public ushort vendor_id;

    [NativeTypeName("Uint16")]
    public ushort product_id;

    [NativeTypeName("Uint16")]
    public ushort naxes;

    [NativeTypeName("Uint16")]
    public ushort nbuttons;

    [NativeTypeName("Uint16")]
    public ushort nballs;

    [NativeTypeName("Uint16")]
    public ushort nhats;

    [NativeTypeName("Uint16")]
    public ushort ntouchpads;

    [NativeTypeName("Uint16")]
    public ushort nsensors;

    [NativeTypeName("Uint16[2]")]
    public _padding2_e__FixedBuffer padding2;

    [NativeTypeName("Uint32")]
    public uint button_mask;

    [NativeTypeName("Uint32")]
    public uint axis_mask;

    [NativeTypeName("const char *")]
    public byte* name;

    [NativeTypeName("const SDL_VirtualJoystickTouchpadDesc *")]
    public SDL_VirtualJoystickTouchpadDesc* touchpads;

    [NativeTypeName("const SDL_VirtualJoystickSensorDesc *")]
    public SDL_VirtualJoystickSensorDesc* sensors;

    public void* userdata;

    [NativeTypeName("void (*)(void *) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, void> Update;

    [NativeTypeName("void (*)(void *, int) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, int, void> SetPlayerIndex;

    [NativeTypeName("_Bool (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, ushort, ushort, byte> Rumble;

    [NativeTypeName("_Bool (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, ushort, ushort, byte> RumbleTriggers;

    [NativeTypeName("_Bool (*)(void *, Uint8, Uint8, Uint8) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, byte, byte, byte, byte> SetLED;

    [NativeTypeName("_Bool (*)(void *, const void *, int) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, void*, int, byte> SendEffect;

    [NativeTypeName("_Bool (*)(void *, _Bool) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, byte, byte> SetSensorsEnabled;

    [NativeTypeName("void (*)(void *) __attribute__((cdecl))")]
    public delegate* unmanaged[Cdecl]<void*, void> Cleanup;

    [InlineArray(2)]
    public partial struct _padding2_e__FixedBuffer
    {
        public ushort e0;
    }
}
