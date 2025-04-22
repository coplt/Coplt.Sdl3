using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Haptic
    {
    }

    public partial struct SDL_HapticDirection
    {
        [NativeTypeName("Uint8")]
        public byte type;

        [NativeTypeName("Sint32[3]")]
        public _dir_e__FixedBuffer dir;

        [InlineArray(3)]
        public partial struct _dir_e__FixedBuffer
        {
            public int e0;
        }
    }

    public partial struct SDL_HapticConstant
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Sint16")]
        public short level;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public partial struct SDL_HapticPeriodic
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint16")]
        public ushort period;

        [NativeTypeName("Sint16")]
        public short magnitude;

        [NativeTypeName("Sint16")]
        public short offset;

        [NativeTypeName("Uint16")]
        public ushort phase;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public partial struct SDL_HapticCondition
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint16[3]")]
        public _right_sat_e__FixedBuffer right_sat;

        [NativeTypeName("Uint16[3]")]
        public _left_sat_e__FixedBuffer left_sat;

        [NativeTypeName("Sint16[3]")]
        public _right_coeff_e__FixedBuffer right_coeff;

        [NativeTypeName("Sint16[3]")]
        public _left_coeff_e__FixedBuffer left_coeff;

        [NativeTypeName("Uint16[3]")]
        public _deadband_e__FixedBuffer deadband;

        [NativeTypeName("Sint16[3]")]
        public _center_e__FixedBuffer center;

        [InlineArray(3)]
        public partial struct _right_sat_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(3)]
        public partial struct _left_sat_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(3)]
        public partial struct _right_coeff_e__FixedBuffer
        {
            public short e0;
        }

        [InlineArray(3)]
        public partial struct _left_coeff_e__FixedBuffer
        {
            public short e0;
        }

        [InlineArray(3)]
        public partial struct _deadband_e__FixedBuffer
        {
            public ushort e0;
        }

        [InlineArray(3)]
        public partial struct _center_e__FixedBuffer
        {
            public short e0;
        }
    }

    public partial struct SDL_HapticRamp
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Sint16")]
        public short start;

        [NativeTypeName("Sint16")]
        public short end;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public partial struct SDL_HapticLeftRight
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort large_magnitude;

        [NativeTypeName("Uint16")]
        public ushort small_magnitude;
    }

    public unsafe partial struct SDL_HapticCustom
    {
        [NativeTypeName("Uint16")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint8")]
        public byte channels;

        [NativeTypeName("Uint16")]
        public ushort period;

        [NativeTypeName("Uint16")]
        public ushort samples;

        [NativeTypeName("Uint16 *")]
        public ushort* data;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_HapticEffect
    {
        [FieldOffset(0)]
        [NativeTypeName("Uint16")]
        public ushort type;

        [FieldOffset(0)]
        public SDL_HapticConstant constant;

        [FieldOffset(0)]
        public SDL_HapticPeriodic periodic;

        [FieldOffset(0)]
        public SDL_HapticCondition condition;

        [FieldOffset(0)]
        public SDL_HapticRamp ramp;

        [FieldOffset(0)]
        public SDL_HapticLeftRight leftright;

        [FieldOffset(0)]
        public SDL_HapticCustom custom;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHaptics", ExactSpelling = true)]
        [return: NativeTypeName("SDL_HapticID *")]
        public static extern uint* GetHaptics(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetHapticNameForID([NativeTypeName("SDL_HapticID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHaptic", ExactSpelling = true)]
        public static extern SDL_Haptic* OpenHaptic([NativeTypeName("SDL_HapticID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticFromID", ExactSpelling = true)]
        public static extern SDL_Haptic* GetHapticFromID([NativeTypeName("SDL_HapticID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_HapticID")]
        public static extern uint GetHapticID(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetHapticName(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMouseHaptic", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 IsMouseHaptic();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHapticFromMouse", ExactSpelling = true)]
        public static extern SDL_Haptic* OpenHapticFromMouse();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickHaptic", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 IsJoystickHaptic(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHapticFromJoystick", ExactSpelling = true)]
        public static extern SDL_Haptic* OpenHapticFromJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseHaptic", ExactSpelling = true)]
        public static extern void CloseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMaxHapticEffects", ExactSpelling = true)]
        public static extern int GetMaxHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMaxHapticEffectsPlaying", ExactSpelling = true)]
        public static extern int GetMaxHapticEffectsPlaying(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticFeatures", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint GetHapticFeatures(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumHapticAxes", ExactSpelling = true)]
        public static extern int GetNumHapticAxes(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticEffectSupported", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HapticEffectSupported(SDL_Haptic* haptic, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateHapticEffect", ExactSpelling = true)]
        public static extern int CreateHapticEffect(SDL_Haptic* haptic, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateHapticEffect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 UpdateHapticEffect(SDL_Haptic* haptic, int effect, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunHapticEffect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RunHapticEffect(SDL_Haptic* haptic, int effect, [NativeTypeName("Uint32")] uint iterations);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticEffect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 StopHapticEffect(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyHapticEffect", ExactSpelling = true)]
        public static extern void DestroyHapticEffect(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticEffectStatus", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetHapticEffectStatus(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHapticGain", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetHapticGain(SDL_Haptic* haptic, int gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHapticAutocenter", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetHapticAutocenter(SDL_Haptic* haptic, int autocenter);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseHaptic", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 PauseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeHaptic", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ResumeHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticEffects", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 StopHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRumbleSupported", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HapticRumbleSupported(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitHapticRumble", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 InitHapticRumble(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PlayHapticRumble", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 PlayHapticRumble(SDL_Haptic* haptic, float strength, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticRumble", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 StopHapticRumble(SDL_Haptic* haptic);
    }
}
