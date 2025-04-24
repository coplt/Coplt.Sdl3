using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Cursor
    {
    }

    public enum SDL_SystemCursor
    {
        SDL_SYSTEM_CURSOR_DEFAULT,
        SDL_SYSTEM_CURSOR_TEXT,
        SDL_SYSTEM_CURSOR_WAIT,
        SDL_SYSTEM_CURSOR_CROSSHAIR,
        SDL_SYSTEM_CURSOR_PROGRESS,
        SDL_SYSTEM_CURSOR_NWSE_RESIZE,
        SDL_SYSTEM_CURSOR_NESW_RESIZE,
        SDL_SYSTEM_CURSOR_EW_RESIZE,
        SDL_SYSTEM_CURSOR_NS_RESIZE,
        SDL_SYSTEM_CURSOR_MOVE,
        SDL_SYSTEM_CURSOR_NOT_ALLOWED,
        SDL_SYSTEM_CURSOR_POINTER,
        SDL_SYSTEM_CURSOR_NW_RESIZE,
        SDL_SYSTEM_CURSOR_N_RESIZE,
        SDL_SYSTEM_CURSOR_NE_RESIZE,
        SDL_SYSTEM_CURSOR_E_RESIZE,
        SDL_SYSTEM_CURSOR_SE_RESIZE,
        SDL_SYSTEM_CURSOR_S_RESIZE,
        SDL_SYSTEM_CURSOR_SW_RESIZE,
        SDL_SYSTEM_CURSOR_W_RESIZE,
        SDL_SYSTEM_CURSOR_COUNT,
    }

    public enum SDL_MouseWheelDirection
    {
        SDL_MOUSEWHEEL_NORMAL,
        SDL_MOUSEWHEEL_FLIPPED,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasMouse", ExactSpelling = true)]
        public static extern bool8 HasMouse();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMice", ExactSpelling = true)]
        public static extern SDL_MouseID* GetMice(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseNameForID", ExactSpelling = true)]
        public static extern byte* GetMouseNameForID(SDL_MouseID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseFocus", ExactSpelling = true)]
        public static extern SDL_Window* GetMouseFocus();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseState", ExactSpelling = true)]
        public static extern SDL_MouseButtonFlags GetMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGlobalMouseState", ExactSpelling = true)]
        public static extern SDL_MouseButtonFlags GetGlobalMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRelativeMouseState", ExactSpelling = true)]
        public static extern SDL_MouseButtonFlags GetRelativeMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseInWindow", ExactSpelling = true)]
        public static extern void WarpMouseInWindow(SDL_Window* window, float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseGlobal", ExactSpelling = true)]
        public static extern bool8 WarpMouseGlobal(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowRelativeMouseMode", ExactSpelling = true)]
        public static extern bool8 SetWindowRelativeMouseMode(SDL_Window* window,bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowRelativeMouseMode", ExactSpelling = true)]
        public static extern bool8 GetWindowRelativeMouseMode(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CaptureMouse", ExactSpelling = true)]
        public static extern bool8 CaptureMouse(bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* CreateCursor(byte* data,byte* mask, int w, int h, int hot_x, int hot_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateColorCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSystemCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* CreateSystemCursor(SDL_SystemCursor id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCursor", ExactSpelling = true)]
        public static extern bool8 SetCursor(SDL_Cursor* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* GetCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultCursor", ExactSpelling = true)]
        public static extern SDL_Cursor* GetDefaultCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyCursor", ExactSpelling = true)]
        public static extern void DestroyCursor(SDL_Cursor* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowCursor", ExactSpelling = true)]
        public static extern bool8 ShowCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideCursor", ExactSpelling = true)]
        public static extern bool8 HideCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CursorVisible", ExactSpelling = true)]
        public static extern bool8 CursorVisible();
    }
}
