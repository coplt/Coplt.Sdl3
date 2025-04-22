using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_MessageBoxButtonData
    {
        [NativeTypeName("SDL_MessageBoxButtonFlags")]
        public uint flags;

        public int buttonID;

        [NativeTypeName("const char *")]
        public byte* text;
    }

    public partial struct SDL_MessageBoxColor
    {
        [NativeTypeName("Uint8")]
        public byte r;

        [NativeTypeName("Uint8")]
        public byte g;

        [NativeTypeName("Uint8")]
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
        [NativeTypeName("SDL_MessageBoxColor[5]")]
        public _colors_e__FixedBuffer colors;

        [InlineArray(5)]
        public partial struct _colors_e__FixedBuffer
        {
            public SDL_MessageBoxColor e0;
        }
    }

    public unsafe partial struct SDL_MessageBoxData
    {
        [NativeTypeName("SDL_MessageBoxFlags")]
        public uint flags;

        public SDL_Window* window;

        [NativeTypeName("const char *")]
        public byte* title;

        [NativeTypeName("const char *")]
        public byte* message;

        public int numbuttons;

        [NativeTypeName("const SDL_MessageBoxButtonData *")]
        public SDL_MessageBoxButtonData* buttons;

        [NativeTypeName("const SDL_MessageBoxColorScheme *")]
        public SDL_MessageBoxColorScheme* colorScheme;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowMessageBox", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ShowMessageBox([NativeTypeName("const SDL_MessageBoxData *")] SDL_MessageBoxData* messageboxdata, int* buttonid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSimpleMessageBox", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ShowSimpleMessageBox([NativeTypeName("SDL_MessageBoxFlags")] uint flags, [NativeTypeName("const char *")] byte* title, [NativeTypeName("const char *")] byte* message, SDL_Window* window);
    }
}
