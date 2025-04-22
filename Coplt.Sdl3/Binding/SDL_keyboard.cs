using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_TextInputType
    {
        SDL_TEXTINPUT_TYPE_TEXT,
        SDL_TEXTINPUT_TYPE_TEXT_NAME,
        SDL_TEXTINPUT_TYPE_TEXT_EMAIL,
        SDL_TEXTINPUT_TYPE_TEXT_USERNAME,
        SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_HIDDEN,
        SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_VISIBLE,
        SDL_TEXTINPUT_TYPE_NUMBER,
        SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_HIDDEN,
        SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_VISIBLE,
    }

    public enum SDL_Capitalization
    {
        SDL_CAPITALIZE_NONE,
        SDL_CAPITALIZE_SENTENCES,
        SDL_CAPITALIZE_WORDS,
        SDL_CAPITALIZE_LETTERS,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasKeyboard", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte HasKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboards", ExactSpelling = true)]
        [return: NativeTypeName("SDL_KeyboardID *")]
        public static extern uint* GetKeyboards(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardNameForID", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetKeyboardNameForID([NativeTypeName("SDL_KeyboardID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardFocus", ExactSpelling = true)]
        public static extern SDL_Window* GetKeyboardFocus();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardState", ExactSpelling = true)]
        [return: NativeTypeName("const _Bool *")]
        public static extern bool* GetKeyboardState(int* numkeys);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetKeyboard", ExactSpelling = true)]
        public static extern void ResetKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetModState", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Keymod")]
        public static extern ushort GetModState();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetModState", ExactSpelling = true)]
        public static extern void SetModState([NativeTypeName("SDL_Keymod")] ushort modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromScancode", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Keycode")]
        public static extern uint GetKeyFromScancode(SDL_Scancode scancode, [NativeTypeName("SDL_Keymod")] ushort modstate, [NativeTypeName("_Bool")] byte key_event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromKey", ExactSpelling = true)]
        public static extern SDL_Scancode GetScancodeFromKey([NativeTypeName("SDL_Keycode")] uint key, [NativeTypeName("SDL_Keymod *")] ushort* modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetScancodeName", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetScancodeName(SDL_Scancode scancode, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetScancodeName(SDL_Scancode scancode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromName", ExactSpelling = true)]
        public static extern SDL_Scancode GetScancodeFromName([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetKeyName([NativeTypeName("SDL_Keycode")] uint key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromName", ExactSpelling = true)]
        [return: NativeTypeName("SDL_Keycode")]
        public static extern uint GetKeyFromName([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInput", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte StartTextInput(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInputWithProperties", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte StartTextInputWithProperties(SDL_Window* window, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TextInputActive", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte TextInputActive(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopTextInput", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte StopTextInput(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearComposition", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ClearComposition(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextInputArea", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetTextInputArea(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, int cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextInputArea", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetTextInputArea(SDL_Window* window, SDL_Rect* rect, int* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasScreenKeyboardSupport", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte HasScreenKeyboardSupport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScreenKeyboardShown", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ScreenKeyboardShown(SDL_Window* window);
    }
}
