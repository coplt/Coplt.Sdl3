using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_MessageBoxButtonData
    {
        public uint flags;

        public int buttonID;
        public byte* text;
    }

    public partial struct SDL_MessageBoxColor
    {
        public byte r;
        public byte g;
        public byte b;
    }

    public enum SDL_MessageBoxColorType
    {
        SDL_MESSAGEBOX_COLOR_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_TEXT,
        SDL_MESSAGEBOX_COLOR_BUTTON_BORDER,
        SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED,
        SDL_MESSAGEBOX_COLOR_COUNT,
    }

    public partial struct SDL_MessageBoxColorScheme
    {
        public _colors_e__FixedBuffer colors;

        [InlineArray(5)]
        public partial struct _colors_e__FixedBuffer
        {
            public SDL_MessageBoxColor e0;
        }
    }

    public unsafe partial struct SDL_MessageBoxData
    {
        public uint flags;

        public SDL_Window* window;
        public byte* title;
        public byte* message;

        public int numbuttons;
        public SDL_MessageBoxButtonData* buttons;
        public SDL_MessageBoxColorScheme* colorScheme;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowMessageBox", ExactSpelling = true)]
        public static extern bool8 ShowMessageBox(SDL_MessageBoxData* messageboxdata, int* buttonid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSimpleMessageBox", ExactSpelling = true)]
        public static extern bool8 ShowSimpleMessageBox(uint flags,byte* title,byte* message, SDL_Window* window);
    }
}
