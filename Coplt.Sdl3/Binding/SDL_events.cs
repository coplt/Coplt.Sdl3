using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_EventType
    {
        First = 0,
        Quit = 0x100,
        Terminating,
        LowMemory,
        WillEnterBackground,
        DidEnterBackground,
        WillEnterForeground,
        DidEnterForeground,
        LocaleChanged,
        SystemThemeChanged,
        DisplayOrientation = 0x151,
        DisplayAdded,
        DisplayRemoved,
        DisplayMoved,
        DisplayDesktopModeChanged,
        DisplayCurrentModeChanged,
        DisplayContentScaleChanged,
        DisplayFirst = DisplayOrientation,
        DisplayLast = DisplayContentScaleChanged,
        WindowShown = 0x202,
        WindowHidden,
        WindowExposed,
        WindowMoved,
        WindowResized,
        WindowPixelSizeChanged,
        WindowMetalViewResized,
        WindowMinimized,
        WindowMaximized,
        WindowRestored,
        WindowMouseEnter,
        WindowMouseLeave,
        WindowFocusGained,
        WindowFocusLost,
        WindowCloseRequested,
        WindowHitTest,
        WindowIccprofChanged,
        WindowDisplayChanged,
        WindowDisplayScaleChanged,
        WindowSafeAreaChanged,
        WindowOccluded,
        WindowEnterFullscreen,
        WindowLeaveFullscreen,
        WindowDestroyed,
        WindowHdrStateChanged,
        WindowFirst = WindowShown,
        WindowLast = WindowHdrStateChanged,
        KeyDown = 0x300,
        KeyUp,
        TextEditing,
        TextInput,
        KeymapChanged,
        KeyboardAdded,
        KeyboardRemoved,
        TextEditingCandidates,
        MouseMotion = 0x400,
        MouseButtonDown,
        MouseButtonUp,
        MouseWheel,
        MouseAdded,
        MouseRemoved,
        JoystickAxisMotion = 0x600,
        JoystickBallMotion,
        JoystickHatMotion,
        JoystickButtonDown,
        JoystickButtonUp,
        JoystickAdded,
        JoystickRemoved,
        JoystickBatteryUpdated,
        JoystickUpdateComplete,
        GamepadAxisMotion = 0x650,
        GamepadButtonDown,
        GamepadButtonUp,
        GamepadAdded,
        GamepadRemoved,
        GamepadRemapped,
        GamepadTouchpadDown,
        GamepadTouchpadMotion,
        GamepadTouchpadUp,
        GamepadSensorUpdate,
        GamepadUpdateComplete,
        GamepadSteamHandleUpdated,
        FingerDown = 0x700,
        FingerUp,
        FingerMotion,
        FingerCanceled,
        ClipboardUpdate = 0x900,
        DropFile = 0x1000,
        DropText,
        DropBegin,
        DropComplete,
        DropPosition,
        AudioDeviceAdded = 0x1100,
        AudioDeviceRemoved,
        AudioDeviceFormatChanged,
        SensorUpdate = 0x1200,
        PenProximityIn = 0x1300,
        PenProximityOut,
        PenDown,
        PenUp,
        PenButtonDown,
        PenButtonUp,
        PenMotion,
        PenAxis,
        CameraDeviceAdded = 0x1400,
        CameraDeviceRemoved,
        CameraDeviceApproved,
        CameraDeviceDenied,
        RenderTargetsReset = 0x2000,
        RenderDeviceReset,
        RenderDeviceLost,
        Private0 = 0x4000,
        Private1,
        Private2,
        Private3,
        PollSentinel = 0x7F00,
        User = 0x8000,
        Last = 0xFFFF,
        EnumPadding = 0x7FFFFFFF,
    }

    public partial struct SDL_CommonEvent
    {
        public uint type;
        public uint reserved;
        public ulong timestamp;
    }

    public partial struct SDL_DisplayEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_DisplayID displayID;
        public int data1;
        public int data2;
    }

    public partial struct SDL_WindowEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;
        public int data1;
        public int data2;
    }

    public partial struct SDL_KeyboardDeviceEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_KeyboardID which;
    }

    public partial struct SDL_KeyboardEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_KeyboardID which;

        public SDL_Scancode scancode;

        public SDL_Keycode key;

        public SDL_Keymod mod;
        public ushort raw;
        public bool8 down;
        public bool8 repeat;
    }

    public unsafe partial struct SDL_TextEditingEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;
        public byte* text;
        public int start;
        public int length;
    }

    public unsafe partial struct SDL_TextEditingCandidatesEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;
        public byte** candidates;
        public int num_candidates;
        public int selected_candidate;
        public bool8 horizontal;
        public byte padding1;
        public byte padding2;
        public byte padding3;
    }

    public unsafe partial struct SDL_TextInputEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;
        public byte* text;
    }

    public partial struct SDL_MouseDeviceEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_MouseID which;
    }

    public partial struct SDL_MouseMotionEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_MouseID which;

        public SDL_MouseButtonFlags state;

        public float x;

        public float y;

        public float xrel;

        public float yrel;
    }

    public partial struct SDL_MouseButtonEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_MouseID which;
        public byte button;
        public bool8 down;
        public byte clicks;
        public byte padding;

        public float x;

        public float y;
    }

    public partial struct SDL_MouseWheelEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_MouseID which;

        public float x;

        public float y;

        public SDL_MouseWheelDirection direction;

        public float mouse_x;

        public float mouse_y;
    }

    public partial struct SDL_JoyAxisEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
        public byte axis;
        public byte padding1;
        public byte padding2;
        public byte padding3;
        public short value;
        public ushort padding4;
    }

    public partial struct SDL_JoyBallEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
        public byte ball;
        public byte padding1;
        public byte padding2;
        public byte padding3;
        public short xrel;
        public short yrel;
    }

    public partial struct SDL_JoyHatEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
        public byte hat;
        public byte value;
        public byte padding1;
        public byte padding2;
    }

    public partial struct SDL_JoyButtonEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
        public byte button;
        public bool8 down;
        public byte padding1;
        public byte padding2;
    }

    public partial struct SDL_JoyDeviceEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
    }

    public partial struct SDL_JoyBatteryEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;

        public SDL_PowerState state;

        public int percent;
    }

    public partial struct SDL_GamepadAxisEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
        public byte axis;
        public byte padding1;
        public byte padding2;
        public byte padding3;
        public short value;
        public ushort padding4;
    }

    public partial struct SDL_GamepadButtonEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
        public byte button;
        public bool8 down;
        public byte padding1;
        public byte padding2;
    }

    public partial struct SDL_GamepadDeviceEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
    }

    public partial struct SDL_GamepadTouchpadEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
        public int touchpad;
        public int finger;

        public float x;

        public float y;

        public float pressure;
    }

    public partial struct SDL_GamepadSensorEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_JoystickID which;
        public int sensor;
        public _data_e__FixedBuffer data;
        public ulong sensor_timestamp;

        [InlineArray(3)]
        public partial struct _data_e__FixedBuffer
        {
            public float e0;
        }
    }

    public partial struct SDL_AudioDeviceEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_AudioDeviceID which;
        public bool8 recording;
        public byte padding1;
        public byte padding2;
        public byte padding3;
    }

    public partial struct SDL_CameraDeviceEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_CameraID which;
    }

    public partial struct SDL_RenderEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;
    }

    public partial struct SDL_TouchFingerEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_TouchID touchID;

        public SDL_FingerID fingerID;

        public float x;

        public float y;

        public float dx;

        public float dy;

        public float pressure;

        public SDL_WindowID windowID;
    }

    public partial struct SDL_PenProximityEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_PenID which;
    }

    public partial struct SDL_PenMotionEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_PenID which;

        public SDL_PenInputFlags pen_state;

        public float x;

        public float y;
    }

    public partial struct SDL_PenTouchEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_PenID which;

        public SDL_PenInputFlags pen_state;

        public float x;

        public float y;
        public bool8 eraser;
        public bool8 down;
    }

    public partial struct SDL_PenButtonEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_PenID which;

        public SDL_PenInputFlags pen_state;

        public float x;

        public float y;
        public byte button;
        public bool8 down;
    }

    public partial struct SDL_PenAxisEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public SDL_PenID which;

        public SDL_PenInputFlags pen_state;

        public float x;

        public float y;

        public SDL_PenAxis axis;

        public float value;
    }

    public unsafe partial struct SDL_DropEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;

        public float x;

        public float y;
        public byte* source;
        public byte* data;
    }

    public unsafe partial struct SDL_ClipboardEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;
        public bool8 owner;
        public int num_mime_types;
        public byte** mime_types;
    }

    public partial struct SDL_SensorEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;

        public SDL_SensorID which;
        public _data_e__FixedBuffer data;
        public ulong sensor_timestamp;

        [InlineArray(6)]
        public partial struct _data_e__FixedBuffer
        {
            public float e0;
        }
    }

    public partial struct SDL_QuitEvent
    {
        public SDL_EventType type;
        public uint reserved;
        public ulong timestamp;
    }

    public unsafe partial struct SDL_UserEvent
    {
        public uint type;
        public uint reserved;
        public ulong timestamp;

        public SDL_WindowID windowID;
        public int code;

        public void* data1;

        public void* data2;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_Event
    {
        [FieldOffset(0)]
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
        public _padding_e__FixedBuffer padding;

        [InlineArray(128)]
        public partial struct _padding_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public enum SDL_EventAction
    {
        Addevent,
        Peekevent,
        Getevent,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PumpEvents", ExactSpelling = true)]
        public static extern void PumpEvents();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PeepEvents", ExactSpelling = true)]
        public static extern int PeepEvents(SDL_Event* events, int numevents, SDL_EventAction action,uint minType,uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvent", ExactSpelling = true)]
        public static extern bool8 HasEvent(uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvents", ExactSpelling = true)]
        public static extern bool8 HasEvents(uint minType,uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushEvent", ExactSpelling = true)]
        public static extern void FlushEvent(uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushEvents", ExactSpelling = true)]
        public static extern void FlushEvents(uint minType,uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PollEvent", ExactSpelling = true)]
        public static extern bool8 PollEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitEvent", ExactSpelling = true)]
        public static extern bool8 WaitEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitEventTimeout", ExactSpelling = true)]
        public static extern bool8 WaitEventTimeout(SDL_Event* @event,int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushEvent", ExactSpelling = true)]
        public static extern bool8 PushEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEventFilter", ExactSpelling = true)]
        public static extern void SetEventFilter(delegate* unmanaged[Cdecl]<void*, SDL_Event*, bool8> filter, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEventFilter", ExactSpelling = true)]
        public static extern bool8 GetEventFilter(delegate* unmanaged[Cdecl]<void*, SDL_Event*, bool8>* filter, void** userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddEventWatch", ExactSpelling = true)]
        public static extern bool8 AddEventWatch(delegate* unmanaged[Cdecl]<void*, SDL_Event*, bool8> filter, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveEventWatch", ExactSpelling = true)]
        public static extern void RemoveEventWatch(delegate* unmanaged[Cdecl]<void*, SDL_Event*, bool8> filter, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FilterEvents", ExactSpelling = true)]
        public static extern void FilterEvents(delegate* unmanaged[Cdecl]<void*, SDL_Event*, bool8> filter, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEventEnabled", ExactSpelling = true)]
        public static extern void SetEventEnabled(uint type,bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EventEnabled", ExactSpelling = true)]
        public static extern bool8 EventEnabled(uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RegisterEvents", ExactSpelling = true)]
        public static extern uint RegisterEvents(int numevents);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFromEvent", ExactSpelling = true)]
        public static extern SDL_Window* GetWindowFromEvent(SDL_Event* @event);
    }
}
