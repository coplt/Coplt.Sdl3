using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Joystick
    {
    }

    public enum SDL_JoystickType
    {
        SDL_JOYSTICK_TYPE_UNKNOWN,
        SDL_JOYSTICK_TYPE_GAMEPAD,
        SDL_JOYSTICK_TYPE_WHEEL,
        SDL_JOYSTICK_TYPE_ARCADE_STICK,
        SDL_JOYSTICK_TYPE_FLIGHT_STICK,
        SDL_JOYSTICK_TYPE_DANCE_PAD,
        SDL_JOYSTICK_TYPE_GUITAR,
        SDL_JOYSTICK_TYPE_DRUM_KIT,
        SDL_JOYSTICK_TYPE_ARCADE_PAD,
        SDL_JOYSTICK_TYPE_THROTTLE,
        SDL_JOYSTICK_TYPE_COUNT,
    }

    public enum SDL_JoystickConnectionState
    {
        SDL_JOYSTICK_CONNECTION_INVALID = -1,
        SDL_JOYSTICK_CONNECTION_UNKNOWN,
        SDL_JOYSTICK_CONNECTION_WIRED,
        SDL_JOYSTICK_CONNECTION_WIRELESS,
    }

    public partial struct SDL_VirtualJoystickTouchpadDesc
    {
        [NativeTypeName("Uint16")]
        public ushort nfingers;

        [NativeTypeName("Uint16[3]")]
        public _padding_e__FixedBuffer padding;

        [InlineArray(3)]
        public partial struct _padding_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public partial struct SDL_VirtualJoystickSensorDesc
    {
        public SDL_SensorType type;

        public float rate;
    }

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
        public delegate* unmanaged[Cdecl]<void*, ushort, ushort, bool8> Rumble;

        [NativeTypeName("_Bool (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, ushort, ushort, bool8> RumbleTriggers;

        [NativeTypeName("_Bool (*)(void *, Uint8, Uint8, Uint8) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte, byte, byte, bool8> SetLED;

        [NativeTypeName("_Bool (*)(void *, const void *, int) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, void*, int, bool8> SendEffect;

        [NativeTypeName("_Bool (*)(void *, _Bool) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, bool8, bool8> SetSensorsEnabled;

        [NativeTypeName("void (*)(void *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, void> Cleanup;

        [InlineArray(2)]
        public partial struct _padding2_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockJoysticks", ExactSpelling = true)]
        public static extern void LockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockJoysticks", ExactSpelling = true)]
        public static extern void UnlockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasJoystick", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasJoystick();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoysticks", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID *")]
        public static extern uint* GetJoysticks(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetJoystickNameForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPathForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetJoystickPathForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndexForID", ExactSpelling = true)]
        public static extern int GetJoystickPlayerIndexForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDForID", ExactSpelling = true)]
        public static extern SDL_GUID GetJoystickGUIDForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendorForID", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GetJoystickVendorForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductForID", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GetJoystickProductForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersionForID", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GetJoystickProductVersionForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickTypeForID", ExactSpelling = true)]
        public static extern SDL_JoystickType GetJoystickTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenJoystick", ExactSpelling = true)]
        public static extern SDL_Joystick* OpenJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromID", ExactSpelling = true)]
        public static extern SDL_Joystick* GetJoystickFromID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromPlayerIndex", ExactSpelling = true)]
        public static extern SDL_Joystick* GetJoystickFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AttachVirtualJoystick", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        public static extern uint AttachVirtualJoystick([NativeTypeName("const SDL_VirtualJoystickDesc *")] SDL_VirtualJoystickDesc* desc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachVirtualJoystick", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 DetachVirtualJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickVirtual", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 IsJoystickVirtual([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualAxis", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16")] short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualBall", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, [NativeTypeName("Sint16")] short xrel, [NativeTypeName("Sint16")] short yrel);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualButton", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetJoystickVirtualButton(SDL_Joystick* joystick, int button, [NativeTypeName("_Bool")] bool8 down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualHat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualTouchpad", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, [NativeTypeName("_Bool")] bool8 down, float x, float y, float pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickVirtualSensorData", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, [NativeTypeName("Uint64")] ulong sensor_timestamp, [NativeTypeName("const float *")] float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetJoystickProperties(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetJoystickName(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPath", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetJoystickPath(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndex", ExactSpelling = true)]
        public static extern int GetJoystickPlayerIndex(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickPlayerIndex", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUID", ExactSpelling = true)]
        public static extern SDL_GUID GetJoystickGUID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendor", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GetJoystickVendor(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProduct", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GetJoystickProduct(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GetJoystickProductVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFirmwareVersion", ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort GetJoystickFirmwareVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSerial", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetJoystickSerial(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickType", ExactSpelling = true)]
        public static extern SDL_JoystickType GetJoystickType(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDInfo", ExactSpelling = true)]
        public static extern void GetJoystickGUIDInfo(SDL_GUID guid, [NativeTypeName("Uint16 *")] ushort* vendor, [NativeTypeName("Uint16 *")] ushort* product, [NativeTypeName("Uint16 *")] ushort* version, [NativeTypeName("Uint16 *")] ushort* crc16);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickConnected", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 JoystickConnected(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        public static extern uint GetJoystickID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickAxes", ExactSpelling = true)]
        public static extern int GetNumJoystickAxes(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickBalls", ExactSpelling = true)]
        public static extern int GetNumJoystickBalls(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickHats", ExactSpelling = true)]
        public static extern int GetNumJoystickHats(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickButtons", ExactSpelling = true)]
        public static extern int GetNumJoystickButtons(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickEventsEnabled", ExactSpelling = true)]
        public static extern void SetJoystickEventsEnabled([NativeTypeName("_Bool")] bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickEventsEnabled", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 JoystickEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateJoysticks", ExactSpelling = true)]
        public static extern void UpdateJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxis", ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        public static extern short GetJoystickAxis(SDL_Joystick* joystick, int axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxisInitialState", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16 *")] short* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickBall", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickHat", ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte GetJoystickHat(SDL_Joystick* joystick, int hat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickButton", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetJoystickButton(SDL_Joystick* joystick, int button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystick", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RumbleJoystick(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystickTriggers", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RumbleJoystickTriggers(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickLED", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetJoystickLED(SDL_Joystick* joystick, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickEffect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SendJoystickEffect(SDL_Joystick* joystick, [NativeTypeName("const void *")] void* data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseJoystick", ExactSpelling = true)]
        public static extern void CloseJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickConnectionState", ExactSpelling = true)]
        public static extern SDL_JoystickConnectionState GetJoystickConnectionState(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPowerInfo", ExactSpelling = true)]
        public static extern SDL_PowerState GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent);
    }
}
