using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Gamepad
    {
    }

    public enum SDL_GamepadType
    {
        Unknown = 0,
        Standard,
        Xbox360,
        Xboxone,
        Ps3,
        Ps4,
        Ps5,
        NintendoSwitchPro,
        NintendoSwitchJoyconLeft,
        NintendoSwitchJoyconRight,
        NintendoSwitchJoyconPair,
        Count,
    }

    public enum SDL_GamepadButton
    {
        Invalid = -1,
        South,
        East,
        West,
        North,
        Back,
        Guide,
        Start,
        LeftStick,
        RightStick,
        LeftShoulder,
        RightShoulder,
        DpadUp,
        DpadDown,
        DpadLeft,
        DpadRight,
        Misc1,
        RightPaddle1,
        LeftPaddle1,
        RightPaddle2,
        LeftPaddle2,
        Touchpad,
        Misc2,
        Misc3,
        Misc4,
        Misc5,
        Misc6,
        Count,
    }

    public enum SDL_GamepadButtonLabel
    {
        Unknown,
        A,
        B,
        X,
        Y,
        Cross,
        Circle,
        Square,
        Triangle,
    }

    public enum SDL_GamepadAxis
    {
        AxisInvalid = -1,
        AxisLeftx,
        AxisLefty,
        AxisRightx,
        AxisRighty,
        AxisLeftTrigger,
        AxisRightTrigger,
        AxisCount,
    }

    public enum SDL_GamepadBindingType
    {
        BindtypeNone = 0,
        BindtypeButton,
        BindtypeAxis,
        BindtypeHat,
    }

    public partial struct SDL_GamepadBinding
    {
        public SDL_GamepadBindingType input_type;
        public _input_e__Union input;

        public SDL_GamepadBindingType output_type;
        public _output_e__Union output;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _input_e__Union
        {
            [FieldOffset(0)]
            public int button;

            [FieldOffset(0)]
            public _axis_e__Struct axis;

            [FieldOffset(0)]
            public _hat_e__Struct hat;

            public partial struct _axis_e__Struct
            {
                public int axis;

                public int axis_min;

                public int axis_max;
            }

            public partial struct _hat_e__Struct
            {
                public int hat;

                public int hat_mask;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _output_e__Union
        {
            [FieldOffset(0)]
            public SDL_GamepadButton button;

            [FieldOffset(0)]
            public _axis_e__Struct axis;

            public partial struct _axis_e__Struct
            {
                public SDL_GamepadAxis axis;

                public int axis_min;

                public int axis_max;
            }
        }
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMapping", ExactSpelling = true)]
        public static extern int AddGamepadMapping(byte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMappingsFromIO", ExactSpelling = true)]
        public static extern int AddGamepadMappingsFromIO(SDL_IOStream* src,bool8 closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMappingsFromFile", ExactSpelling = true)]
        public static extern int AddGamepadMappingsFromFile(byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReloadGamepadMappings", ExactSpelling = true)]
        public static extern bool8 ReloadGamepadMappings();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappings", ExactSpelling = true)]
        public static extern byte** GetGamepadMappings(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForGUID", ExactSpelling = true)]
        public static extern byte* GetGamepadMappingForGUID(SDL_GUID guid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMapping", ExactSpelling = true)]
        public static extern byte* GetGamepadMapping(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadMapping", ExactSpelling = true)]
        public static extern bool8 SetGamepadMapping(SDL_JoystickID instance_id,byte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasGamepad", ExactSpelling = true)]
        public static extern bool8 HasGamepad();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepads", ExactSpelling = true)]
        public static extern SDL_JoystickID* GetGamepads(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsGamepad", ExactSpelling = true)]
        public static extern bool8 IsGamepad(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadNameForID", ExactSpelling = true)]
        public static extern byte* GetGamepadNameForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPathForID", ExactSpelling = true)]
        public static extern byte* GetGamepadPathForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPlayerIndexForID", ExactSpelling = true)]
        public static extern int GetGamepadPlayerIndexForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadGUIDForID", ExactSpelling = true)]
        public static extern SDL_GUID GetGamepadGUIDForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadVendorForID", ExactSpelling = true)]
        public static extern ushort GetGamepadVendorForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductForID", ExactSpelling = true)]
        public static extern ushort GetGamepadProductForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductVersionForID", ExactSpelling = true)]
        public static extern ushort GetGamepadProductVersionForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTypeForID", ExactSpelling = true)]
        public static extern SDL_GamepadType GetGamepadTypeForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadTypeForID", ExactSpelling = true)]
        public static extern SDL_GamepadType GetRealGamepadTypeForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForID", ExactSpelling = true)]
        public static extern byte* GetGamepadMappingForID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenGamepad", ExactSpelling = true)]
        public static extern SDL_Gamepad* OpenGamepad(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromID", ExactSpelling = true)]
        public static extern SDL_Gamepad* GetGamepadFromID(SDL_JoystickID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromPlayerIndex", ExactSpelling = true)]
        public static extern SDL_Gamepad* GetGamepadFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProperties", ExactSpelling = true)]
        public static extern SDL_PropertiesID GetGamepadProperties(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadID", ExactSpelling = true)]
        public static extern SDL_JoystickID GetGamepadID(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadName", ExactSpelling = true)]
        public static extern byte* GetGamepadName(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPath", ExactSpelling = true)]
        public static extern byte* GetGamepadPath(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadType", ExactSpelling = true)]
        public static extern SDL_GamepadType GetGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadType", ExactSpelling = true)]
        public static extern SDL_GamepadType GetRealGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPlayerIndex", ExactSpelling = true)]
        public static extern int GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadPlayerIndex", ExactSpelling = true)]
        public static extern bool8 SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadVendor", ExactSpelling = true)]
        public static extern ushort GetGamepadVendor(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProduct", ExactSpelling = true)]
        public static extern ushort GetGamepadProduct(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductVersion", ExactSpelling = true)]
        public static extern ushort GetGamepadProductVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFirmwareVersion", ExactSpelling = true)]
        public static extern ushort GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSerial", ExactSpelling = true)]
        public static extern byte* GetGamepadSerial(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSteamHandle", ExactSpelling = true)]
        public static extern ulong GetGamepadSteamHandle(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadConnectionState", ExactSpelling = true)]
        public static extern SDL_JoystickConnectionState GetGamepadConnectionState(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPowerInfo", ExactSpelling = true)]
        public static extern SDL_PowerState GetGamepadPowerInfo(SDL_Gamepad* gamepad, int* percent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadConnected", ExactSpelling = true)]
        public static extern bool8 GamepadConnected(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadJoystick", ExactSpelling = true)]
        public static extern SDL_Joystick* GetGamepadJoystick(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadEventsEnabled", ExactSpelling = true)]
        public static extern void SetGamepadEventsEnabled(bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadEventsEnabled", ExactSpelling = true)]
        public static extern bool8 GamepadEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadBindings", ExactSpelling = true)]
        public static extern SDL_GamepadBinding** GetGamepadBindings(SDL_Gamepad* gamepad, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateGamepads", ExactSpelling = true)]
        public static extern void UpdateGamepads();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTypeFromString", ExactSpelling = true)]
        public static extern SDL_GamepadType GetGamepadTypeFromString(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForType", ExactSpelling = true)]
        public static extern byte* GetGamepadStringForType(SDL_GamepadType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAxisFromString", ExactSpelling = true)]
        public static extern SDL_GamepadAxis GetGamepadAxisFromString(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForAxis", ExactSpelling = true)]
        public static extern byte* GetGamepadStringForAxis(SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasAxis", ExactSpelling = true)]
        public static extern bool8 GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAxis", ExactSpelling = true)]
        public static extern short GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonFromString", ExactSpelling = true)]
        public static extern SDL_GamepadButton GetGamepadButtonFromString(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForButton", ExactSpelling = true)]
        public static extern byte* GetGamepadStringForButton(SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasButton", ExactSpelling = true)]
        public static extern bool8 GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButton", ExactSpelling = true)]
        public static extern bool8 GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonLabelForType", ExactSpelling = true)]
        public static extern SDL_GamepadButtonLabel GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonLabel", ExactSpelling = true)]
        public static extern SDL_GamepadButtonLabel GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadTouchpads", ExactSpelling = true)]
        public static extern int GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadTouchpadFingers", ExactSpelling = true)]
        public static extern int GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTouchpadFinger", ExactSpelling = true)]
        public static extern bool8 GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger,bool8* down, float* x, float* y, float* pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasSensor", ExactSpelling = true)]
        public static extern bool8 GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadSensorEnabled", ExactSpelling = true)]
        public static extern bool8 SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type,bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadSensorEnabled", ExactSpelling = true)]
        public static extern bool8 GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSensorDataRate", ExactSpelling = true)]
        public static extern float GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSensorData", ExactSpelling = true)]
        public static extern bool8 GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleGamepad", ExactSpelling = true)]
        public static extern bool8 RumbleGamepad(SDL_Gamepad* gamepad,ushort low_frequency_rumble,ushort high_frequency_rumble,uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleGamepadTriggers", ExactSpelling = true)]
        public static extern bool8 RumbleGamepadTriggers(SDL_Gamepad* gamepad,ushort left_rumble,ushort right_rumble,uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadLED", ExactSpelling = true)]
        public static extern bool8 SetGamepadLED(SDL_Gamepad* gamepad,byte red,byte green,byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendGamepadEffect", ExactSpelling = true)]
        public static extern bool8 SendGamepadEffect(SDL_Gamepad* gamepad,void* data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseGamepad", ExactSpelling = true)]
        public static extern void CloseGamepad(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton", ExactSpelling = true)]
        public static extern byte* GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis", ExactSpelling = true)]
        public static extern byte* GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);
    }
}
