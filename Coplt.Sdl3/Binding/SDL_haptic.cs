using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Haptic
    {
    }

    public partial struct SDL_HapticDirection
    {
        public byte type;
        public _dir_e__FixedBuffer dir;

        [InlineArray(3)]
        public partial struct _dir_e__FixedBuffer
        {
            public int e0;
        }
    }

    public partial struct SDL_HapticConstant
    {
        public ushort type;

        public SDL_HapticDirection direction;
        public uint length;
        public ushort delay;
        public ushort button;
        public ushort interval;
        public short level;
        public ushort attack_length;
        public ushort attack_level;
        public ushort fade_length;
        public ushort fade_level;
    }

    public partial struct SDL_HapticPeriodic
    {
        public ushort type;

        public SDL_HapticDirection direction;
        public uint length;
        public ushort delay;
        public ushort button;
        public ushort interval;
        public ushort period;
        public short magnitude;
        public short offset;
        public ushort phase;
        public ushort attack_length;
        public ushort attack_level;
        public ushort fade_length;
        public ushort fade_level;
    }

    public partial struct SDL_HapticCondition
    {
        public ushort type;

        public SDL_HapticDirection direction;
        public uint length;
        public ushort delay;
        public ushort button;
        public ushort interval;
        public _right_sat_e__FixedBuffer right_sat;
        public _left_sat_e__FixedBuffer left_sat;
        public _right_coeff_e__FixedBuffer right_coeff;
        public _left_coeff_e__FixedBuffer left_coeff;
        public _deadband_e__FixedBuffer deadband;
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
        public ushort type;

        public SDL_HapticDirection direction;
        public uint length;
        public ushort delay;
        public ushort button;
        public ushort interval;
        public short start;
        public short end;
        public ushort attack_length;
        public ushort attack_level;
        public ushort fade_length;
        public ushort fade_level;
    }

    public partial struct SDL_HapticLeftRight
    {
        public ushort type;
        public uint length;
        public ushort large_magnitude;
        public ushort small_magnitude;
    }

    public unsafe partial struct SDL_HapticCustom
    {
        public ushort type;

        public SDL_HapticDirection direction;
        public uint length;
        public ushort delay;
        public ushort button;
        public ushort interval;
        public byte channels;
        public ushort period;
        public ushort samples;
        public ushort* data;
        public ushort attack_length;
        public ushort attack_level;
        public ushort fade_length;
        public ushort fade_level;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_HapticEffect
    {
        [FieldOffset(0)]
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
        public static extern uint* GetHaptics(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticNameForID", ExactSpelling = true)]
        public static extern byte* GetHapticNameForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHaptic", ExactSpelling = true)]
        public static extern SDL_Haptic* OpenHaptic(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticFromID", ExactSpelling = true)]
        public static extern SDL_Haptic* GetHapticFromID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticID", ExactSpelling = true)]
        public static extern uint GetHapticID(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticName", ExactSpelling = true)]
        public static extern byte* GetHapticName(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMouseHaptic", ExactSpelling = true)]
        public static extern bool8 IsMouseHaptic();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHapticFromMouse", ExactSpelling = true)]
        public static extern SDL_Haptic* OpenHapticFromMouse();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickHaptic", ExactSpelling = true)]
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
        public static extern uint GetHapticFeatures(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumHapticAxes", ExactSpelling = true)]
        public static extern int GetNumHapticAxes(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticEffectSupported", ExactSpelling = true)]
        public static extern bool8 HapticEffectSupported(SDL_Haptic* haptic,SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateHapticEffect", ExactSpelling = true)]
        public static extern int CreateHapticEffect(SDL_Haptic* haptic,SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateHapticEffect", ExactSpelling = true)]
        public static extern bool8 UpdateHapticEffect(SDL_Haptic* haptic, int effect,SDL_HapticEffect* data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunHapticEffect", ExactSpelling = true)]
        public static extern bool8 RunHapticEffect(SDL_Haptic* haptic, int effect,uint iterations);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticEffect", ExactSpelling = true)]
        public static extern bool8 StopHapticEffect(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyHapticEffect", ExactSpelling = true)]
        public static extern void DestroyHapticEffect(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticEffectStatus", ExactSpelling = true)]
        public static extern bool8 GetHapticEffectStatus(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHapticGain", ExactSpelling = true)]
        public static extern bool8 SetHapticGain(SDL_Haptic* haptic, int gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHapticAutocenter", ExactSpelling = true)]
        public static extern bool8 SetHapticAutocenter(SDL_Haptic* haptic, int autocenter);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseHaptic", ExactSpelling = true)]
        public static extern bool8 PauseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeHaptic", ExactSpelling = true)]
        public static extern bool8 ResumeHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticEffects", ExactSpelling = true)]
        public static extern bool8 StopHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRumbleSupported", ExactSpelling = true)]
        public static extern bool8 HapticRumbleSupported(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitHapticRumble", ExactSpelling = true)]
        public static extern bool8 InitHapticRumble(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PlayHapticRumble", ExactSpelling = true)]
        public static extern bool8 PlayHapticRumble(SDL_Haptic* haptic, float strength,uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticRumble", ExactSpelling = true)]
        public static extern bool8 StopHapticRumble(SDL_Haptic* haptic);
    }
}
