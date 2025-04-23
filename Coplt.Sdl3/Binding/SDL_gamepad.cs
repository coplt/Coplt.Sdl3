using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Gamepad
    {
    }

    public enum SDL_GamepadType
    {
        SDL_GAMEPAD_TYPE_UNKNOWN = 0,
        SDL_GAMEPAD_TYPE_STANDARD,
        SDL_GAMEPAD_TYPE_XBOX360,
        SDL_GAMEPAD_TYPE_XBOXONE,
        SDL_GAMEPAD_TYPE_PS3,
        SDL_GAMEPAD_TYPE_PS4,
        SDL_GAMEPAD_TYPE_PS5,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_PRO,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_LEFT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_PAIR,
        SDL_GAMEPAD_TYPE_COUNT,
    }

    public enum SDL_GamepadButton
    {
        SDL_GAMEPAD_BUTTON_INVALID = -1,
        SDL_GAMEPAD_BUTTON_SOUTH,
        SDL_GAMEPAD_BUTTON_EAST,
        SDL_GAMEPAD_BUTTON_WEST,
        SDL_GAMEPAD_BUTTON_NORTH,
        SDL_GAMEPAD_BUTTON_BACK,
        SDL_GAMEPAD_BUTTON_GUIDE,
        SDL_GAMEPAD_BUTTON_START,
        SDL_GAMEPAD_BUTTON_LEFT_STICK,
        SDL_GAMEPAD_BUTTON_RIGHT_STICK,
        SDL_GAMEPAD_BUTTON_LEFT_SHOULDER,
        SDL_GAMEPAD_BUTTON_RIGHT_SHOULDER,
        SDL_GAMEPAD_BUTTON_DPAD_UP,
        SDL_GAMEPAD_BUTTON_DPAD_DOWN,
        SDL_GAMEPAD_BUTTON_DPAD_LEFT,
        SDL_GAMEPAD_BUTTON_DPAD_RIGHT,
        SDL_GAMEPAD_BUTTON_MISC1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE1,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE2,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE2,
        SDL_GAMEPAD_BUTTON_TOUCHPAD,
        SDL_GAMEPAD_BUTTON_MISC2,
        SDL_GAMEPAD_BUTTON_MISC3,
        SDL_GAMEPAD_BUTTON_MISC4,
        SDL_GAMEPAD_BUTTON_MISC5,
        SDL_GAMEPAD_BUTTON_MISC6,
        SDL_GAMEPAD_BUTTON_COUNT,
    }

    public enum SDL_GamepadButtonLabel
    {
        SDL_GAMEPAD_BUTTON_LABEL_UNKNOWN,
        SDL_GAMEPAD_BUTTON_LABEL_A,
        SDL_GAMEPAD_BUTTON_LABEL_B,
        SDL_GAMEPAD_BUTTON_LABEL_X,
        SDL_GAMEPAD_BUTTON_LABEL_Y,
        SDL_GAMEPAD_BUTTON_LABEL_CROSS,
        SDL_GAMEPAD_BUTTON_LABEL_CIRCLE,
        SDL_GAMEPAD_BUTTON_LABEL_SQUARE,
        SDL_GAMEPAD_BUTTON_LABEL_TRIANGLE,
    }

    public enum SDL_GamepadAxis
    {
        SDL_GAMEPAD_AXIS_INVALID = -1,
        SDL_GAMEPAD_AXIS_LEFTX,
        SDL_GAMEPAD_AXIS_LEFTY,
        SDL_GAMEPAD_AXIS_RIGHTX,
        SDL_GAMEPAD_AXIS_RIGHTY,
        SDL_GAMEPAD_AXIS_LEFT_TRIGGER,
        SDL_GAMEPAD_AXIS_RIGHT_TRIGGER,
        SDL_GAMEPAD_AXIS_COUNT,
    }

    public enum SDL_GamepadBindingType
    {
        SDL_GAMEPAD_BINDTYPE_NONE = 0,
        SDL_GAMEPAD_BINDTYPE_BUTTON,
        SDL_GAMEPAD_BINDTYPE_AXIS,
        SDL_GAMEPAD_BINDTYPE_HAT,
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
        public static extern bool8 SetGamepadMapping(uint instance_id,byte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasGamepad", ExactSpelling = true)]
        public static extern bool8 HasGamepad();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepads", ExactSpelling = true)]
        public static extern uint* GetGamepads(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsGamepad", ExactSpelling = true)]
        public static extern bool8 IsGamepad(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadNameForID", ExactSpelling = true)]
        public static extern byte* GetGamepadNameForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPathForID", ExactSpelling = true)]
        public static extern byte* GetGamepadPathForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPlayerIndexForID", ExactSpelling = true)]
        public static extern int GetGamepadPlayerIndexForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadGUIDForID", ExactSpelling = true)]
        public static extern SDL_GUID GetGamepadGUIDForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadVendorForID", ExactSpelling = true)]
        public static extern ushort GetGamepadVendorForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductForID", ExactSpelling = true)]
        public static extern ushort GetGamepadProductForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductVersionForID", ExactSpelling = true)]
        public static extern ushort GetGamepadProductVersionForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTypeForID", ExactSpelling = true)]
        public static extern SDL_GamepadType GetGamepadTypeForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadTypeForID", ExactSpelling = true)]
        public static extern SDL_GamepadType GetRealGamepadTypeForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForID", ExactSpelling = true)]
        public static extern byte* GetGamepadMappingForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenGamepad", ExactSpelling = true)]
        public static extern SDL_Gamepad* OpenGamepad(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromID", ExactSpelling = true)]
        public static extern SDL_Gamepad* GetGamepadFromID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromPlayerIndex", ExactSpelling = true)]
        public static extern SDL_Gamepad* GetGamepadFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProperties", ExactSpelling = true)]
        public static extern uint GetGamepadProperties(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadID", ExactSpelling = true)]
        public static extern uint GetGamepadID(SDL_Gamepad* gamepad);

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
