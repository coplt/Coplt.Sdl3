using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_MessageBoxButtonData
    {
        public SDL_MessageBoxButtonFlags flags;

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
        ColorBackground,
        ColorText,
        ColorButtonBorder,
        ColorButtonBackground,
        ColorButtonSelected,
        ColorCount,
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
        public SDL_MessageBoxFlags flags;

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
        public static extern bool8 ShowSimpleMessageBox(SDL_MessageBoxFlags flags,byte* title,byte* message, SDL_Window* window);
    }
}
