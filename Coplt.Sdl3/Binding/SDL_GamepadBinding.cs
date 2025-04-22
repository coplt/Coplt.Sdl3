using System.Runtime.InteropServices;

namespace Coplt.Sdl3;

public partial struct SDL_GamepadBinding
{
    public SDL_GamepadBindingType input_type;

    [NativeTypeName("__AnonymousRecord_SDL_gamepad_L265_C5")]
    public _input_e__Union input;

    public SDL_GamepadBindingType output_type;

    [NativeTypeName("__AnonymousRecord_SDL_gamepad_L285_C5")]
    public _output_e__Union output;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _input_e__Union
    {
        [FieldOffset(0)]
        public int button;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L269_C9")]
        public _axis_e__Struct axis;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L276_C9")]
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
        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L289_C9")]
        public _axis_e__Struct axis;

        public partial struct _axis_e__Struct
        {
            public SDL_GamepadAxis axis;

            public int axis_min;

            public int axis_max;
        }
    }
}
