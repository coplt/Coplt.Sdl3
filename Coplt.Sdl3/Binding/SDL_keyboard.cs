using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_TextInputType
    {
        TypeText,
        TypeTextName,
        TypeTextEmail,
        TypeTextUsername,
        TypeTextPasswordHidden,
        TypeTextPasswordVisible,
        TypeNumber,
        TypeNumberPasswordHidden,
        TypeNumberPasswordVisible,
    }

    public enum SDL_Capitalization
    {
        None,
        Sentences,
        Words,
        Letters,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasKeyboard", ExactSpelling = true)]
        public static extern bool8 HasKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboards", ExactSpelling = true)]
        public static extern SDL_KeyboardID* GetKeyboards(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardNameForID", ExactSpelling = true)]
        public static extern byte* GetKeyboardNameForID(SDL_KeyboardID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardFocus", ExactSpelling = true)]
        public static extern SDL_Window* GetKeyboardFocus();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardState", ExactSpelling = true)]
        public static extern bool8* GetKeyboardState(int* numkeys);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetKeyboard", ExactSpelling = true)]
        public static extern void ResetKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetModState", ExactSpelling = true)]
        public static extern SDL_Keymod GetModState();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetModState", ExactSpelling = true)]
        public static extern void SetModState(SDL_Keymod modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromScancode", ExactSpelling = true)]
        public static extern SDL_Keycode GetKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modstate,bool8 key_event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromKey", ExactSpelling = true)]
        public static extern SDL_Scancode GetScancodeFromKey(SDL_Keycode key, SDL_Keymod* modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetScancodeName", ExactSpelling = true)]
        public static extern bool8 SetScancodeName(SDL_Scancode scancode,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeName", ExactSpelling = true)]
        public static extern byte* GetScancodeName(SDL_Scancode scancode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromName", ExactSpelling = true)]
        public static extern SDL_Scancode GetScancodeFromName(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyName", ExactSpelling = true)]
        public static extern byte* GetKeyName(SDL_Keycode key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromName", ExactSpelling = true)]
        public static extern SDL_Keycode GetKeyFromName(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInput", ExactSpelling = true)]
        public static extern bool8 StartTextInput(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInputWithProperties", ExactSpelling = true)]
        public static extern bool8 StartTextInputWithProperties(SDL_Window* window, SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TextInputActive", ExactSpelling = true)]
        public static extern bool8 TextInputActive(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopTextInput", ExactSpelling = true)]
        public static extern bool8 StopTextInput(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearComposition", ExactSpelling = true)]
        public static extern bool8 ClearComposition(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextInputArea", ExactSpelling = true)]
        public static extern bool8 SetTextInputArea(SDL_Window* window,SDL_Rect* rect, int cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextInputArea", ExactSpelling = true)]
        public static extern bool8 GetTextInputArea(SDL_Window* window, SDL_Rect* rect, int* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasScreenKeyboardSupport", ExactSpelling = true)]
        public static extern bool8 HasScreenKeyboardSupport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScreenKeyboardShown", ExactSpelling = true)]
        public static extern bool8 ScreenKeyboardShown(SDL_Window* window);
    }
}
