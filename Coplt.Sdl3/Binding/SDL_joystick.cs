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
        public ushort nfingers;
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
        public uint version;
        public ushort type;
        public ushort padding;
        public ushort vendor_id;
        public ushort product_id;
        public ushort naxes;
        public ushort nbuttons;
        public ushort nballs;
        public ushort nhats;
        public ushort ntouchpads;
        public ushort nsensors;
        public _padding2_e__FixedBuffer padding2;
        public uint button_mask;
        public uint axis_mask;
        public byte* name;
        public SDL_VirtualJoystickTouchpadDesc* touchpads;
        public SDL_VirtualJoystickSensorDesc* sensors;

        public void* userdata;
        public delegate* unmanaged[Cdecl]<void*, void> Update;
        public delegate* unmanaged[Cdecl]<void*, int, void> SetPlayerIndex;
        public delegate* unmanaged[Cdecl]<void*, ushort, ushort, bool8> Rumble;
        public delegate* unmanaged[Cdecl]<void*, ushort, ushort, bool8> RumbleTriggers;
        public delegate* unmanaged[Cdecl]<void*, byte, byte, byte, bool8> SetLED;
        public delegate* unmanaged[Cdecl]<void*, void*, int, bool8> SendEffect;
        public delegate* unmanaged[Cdecl]<void*, bool8, bool8> SetSensorsEnabled;
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
        public static extern bool8 HasJoystick();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoysticks", ExactSpelling = true)]
        public static extern uint* GetJoysticks(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickNameForID", ExactSpelling = true)]
        public static extern byte* GetJoystickNameForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPathForID", ExactSpelling = true)]
        public static extern byte* GetJoystickPathForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndexForID", ExactSpelling = true)]
        public static extern int GetJoystickPlayerIndexForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDForID", ExactSpelling = true)]
        public static extern SDL_GUID GetJoystickGUIDForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendorForID", ExactSpelling = true)]
        public static extern ushort GetJoystickVendorForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductForID", ExactSpelling = true)]
        public static extern ushort GetJoystickProductForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersionForID", ExactSpelling = true)]
        public static extern ushort GetJoystickProductVersionForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickTypeForID", ExactSpelling = true)]
        public static extern SDL_JoystickType GetJoystickTypeForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenJoystick", ExactSpelling = true)]
        public static extern SDL_Joystick* OpenJoystick(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromID", ExactSpelling = true)]
        public static extern SDL_Joystick* GetJoystickFromID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromPlayerIndex", ExactSpelling = true)]
        public static extern SDL_Joystick* GetJoystickFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AttachVirtualJoystick", ExactSpelling = true)]
        public static extern uint AttachVirtualJoystick(SDL_VirtualJoystickDesc* desc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachVirtualJoystick", ExactSpelling = true)]
        public static extern bool8 DetachVirtualJoystick(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickVirtual", ExactSpelling = true)]
        public static extern bool8 IsJoystickVirtual(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualAxis", ExactSpelling = true)]
        public static extern bool8 SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis,short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualBall", ExactSpelling = true)]
        public static extern bool8 SetJoystickVirtualBall(SDL_Joystick* joystick, int ball,short xrel,short yrel);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualButton", ExactSpelling = true)]
        public static extern bool8 SetJoystickVirtualButton(SDL_Joystick* joystick, int button,bool8 down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualHat", ExactSpelling = true)]
        public static extern bool8 SetJoystickVirtualHat(SDL_Joystick* joystick, int hat,byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualTouchpad", ExactSpelling = true)]
        public static extern bool8 SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger,bool8 down, float x, float y, float pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickVirtualSensorData", ExactSpelling = true)]
        public static extern bool8 SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type,ulong sensor_timestamp,float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProperties", ExactSpelling = true)]
        public static extern uint GetJoystickProperties(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickName", ExactSpelling = true)]
        public static extern byte* GetJoystickName(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPath", ExactSpelling = true)]
        public static extern byte* GetJoystickPath(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndex", ExactSpelling = true)]
        public static extern int GetJoystickPlayerIndex(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickPlayerIndex", ExactSpelling = true)]
        public static extern bool8 SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUID", ExactSpelling = true)]
        public static extern SDL_GUID GetJoystickGUID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendor", ExactSpelling = true)]
        public static extern ushort GetJoystickVendor(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProduct", ExactSpelling = true)]
        public static extern ushort GetJoystickProduct(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersion", ExactSpelling = true)]
        public static extern ushort GetJoystickProductVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFirmwareVersion", ExactSpelling = true)]
        public static extern ushort GetJoystickFirmwareVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSerial", ExactSpelling = true)]
        public static extern byte* GetJoystickSerial(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickType", ExactSpelling = true)]
        public static extern SDL_JoystickType GetJoystickType(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDInfo", ExactSpelling = true)]
        public static extern void GetJoystickGUIDInfo(SDL_GUID guid,ushort* vendor,ushort* product,ushort* version,ushort* crc16);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickConnected", ExactSpelling = true)]
        public static extern bool8 JoystickConnected(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickID", ExactSpelling = true)]
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
        public static extern void SetJoystickEventsEnabled(bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickEventsEnabled", ExactSpelling = true)]
        public static extern bool8 JoystickEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateJoysticks", ExactSpelling = true)]
        public static extern void UpdateJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxis", ExactSpelling = true)]
        public static extern short GetJoystickAxis(SDL_Joystick* joystick, int axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxisInitialState", ExactSpelling = true)]
        public static extern bool8 GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis,short* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickBall", ExactSpelling = true)]
        public static extern bool8 GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickHat", ExactSpelling = true)]
        public static extern byte GetJoystickHat(SDL_Joystick* joystick, int hat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickButton", ExactSpelling = true)]
        public static extern bool8 GetJoystickButton(SDL_Joystick* joystick, int button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystick", ExactSpelling = true)]
        public static extern bool8 RumbleJoystick(SDL_Joystick* joystick,ushort low_frequency_rumble,ushort high_frequency_rumble,uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystickTriggers", ExactSpelling = true)]
        public static extern bool8 RumbleJoystickTriggers(SDL_Joystick* joystick,ushort left_rumble,ushort right_rumble,uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickLED", ExactSpelling = true)]
        public static extern bool8 SetJoystickLED(SDL_Joystick* joystick,byte red,byte green,byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickEffect", ExactSpelling = true)]
        public static extern bool8 SendJoystickEffect(SDL_Joystick* joystick,void* data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseJoystick", ExactSpelling = true)]
        public static extern void CloseJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickConnectionState", ExactSpelling = true)]
        public static extern SDL_JoystickConnectionState GetJoystickConnectionState(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPowerInfo", ExactSpelling = true)]
        public static extern SDL_PowerState GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent);
    }
}
