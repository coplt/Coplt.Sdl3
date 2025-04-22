using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3;

[StructLayout(LayoutKind.Explicit)]
public partial struct SDL_Event
{
    [FieldOffset(0)]
    [NativeTypeName("Uint32")]
    public uint type;

    [FieldOffset(0)]
    public SDL_CommonEvent common;

    [FieldOffset(0)]
    public SDL_DisplayEvent display;

    [FieldOffset(0)]
    public SDL_WindowEvent window;

    [FieldOffset(0)]
    public SDL_KeyboardDeviceEvent kdevice;

    [FieldOffset(0)]
    public SDL_KeyboardEvent key;

    [FieldOffset(0)]
    public SDL_TextEditingEvent edit;

    [FieldOffset(0)]
    public SDL_TextEditingCandidatesEvent edit_candidates;

    [FieldOffset(0)]
    public SDL_TextInputEvent text;

    [FieldOffset(0)]
    public SDL_MouseDeviceEvent mdevice;

    [FieldOffset(0)]
    public SDL_MouseMotionEvent motion;

    [FieldOffset(0)]
    public SDL_MouseButtonEvent button;

    [FieldOffset(0)]
    public SDL_MouseWheelEvent wheel;

    [FieldOffset(0)]
    public SDL_JoyDeviceEvent jdevice;

    [FieldOffset(0)]
    public SDL_JoyAxisEvent jaxis;

    [FieldOffset(0)]
    public SDL_JoyBallEvent jball;

    [FieldOffset(0)]
    public SDL_JoyHatEvent jhat;

    [FieldOffset(0)]
    public SDL_JoyButtonEvent jbutton;

    [FieldOffset(0)]
    public SDL_JoyBatteryEvent jbattery;

    [FieldOffset(0)]
    public SDL_GamepadDeviceEvent gdevice;

    [FieldOffset(0)]
    public SDL_GamepadAxisEvent gaxis;

    [FieldOffset(0)]
    public SDL_GamepadButtonEvent gbutton;

    [FieldOffset(0)]
    public SDL_GamepadTouchpadEvent gtouchpad;

    [FieldOffset(0)]
    public SDL_GamepadSensorEvent gsensor;

    [FieldOffset(0)]
    public SDL_AudioDeviceEvent adevice;

    [FieldOffset(0)]
    public SDL_CameraDeviceEvent cdevice;

    [FieldOffset(0)]
    public SDL_SensorEvent sensor;

    [FieldOffset(0)]
    public SDL_QuitEvent quit;

    [FieldOffset(0)]
    public SDL_UserEvent user;

    [FieldOffset(0)]
    public SDL_TouchFingerEvent tfinger;

    [FieldOffset(0)]
    public SDL_PenProximityEvent pproximity;

    [FieldOffset(0)]
    public SDL_PenTouchEvent ptouch;

    [FieldOffset(0)]
    public SDL_PenMotionEvent pmotion;

    [FieldOffset(0)]
    public SDL_PenButtonEvent pbutton;

    [FieldOffset(0)]
    public SDL_PenAxisEvent paxis;

    [FieldOffset(0)]
    public SDL_RenderEvent render;

    [FieldOffset(0)]
    public SDL_DropEvent drop;

    [FieldOffset(0)]
    public SDL_ClipboardEvent clipboard;

    [FieldOffset(0)]
    [NativeTypeName("Uint8[128]")]
    public _padding_e__FixedBuffer padding;

    [InlineArray(128)]
    public partial struct _padding_e__FixedBuffer
    {
        public byte e0;
    }
}
