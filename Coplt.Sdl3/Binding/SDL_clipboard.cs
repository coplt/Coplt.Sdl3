using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardText", ExactSpelling = true)]
        public static extern bool8 SetClipboardText(byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardText", ExactSpelling = true)]
        public static extern byte* GetClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardText", ExactSpelling = true)]
        public static extern bool8 HasClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPrimarySelectionText", ExactSpelling = true)]
        public static extern bool8 SetPrimarySelectionText(byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimarySelectionText", ExactSpelling = true)]
        public static extern byte* GetPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasPrimarySelectionText", ExactSpelling = true)]
        public static extern bool8 HasPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardData", ExactSpelling = true)]
        public static extern bool8 SetClipboardData(delegate* unmanaged[Cdecl]<void*, byte*, nuint*, void*> callback,delegate* unmanaged[Cdecl]<void*, void> cleanup, void* userdata,byte** mime_types,nuint num_mime_types);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearClipboardData", ExactSpelling = true)]
        public static extern bool8 ClearClipboardData();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardData", ExactSpelling = true)]
        public static extern void* GetClipboardData(byte* mime_type,nuint* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardData", ExactSpelling = true)]
        public static extern bool8 HasClipboardData(byte* mime_type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardMimeTypes", ExactSpelling = true)]
        public static extern byte** GetClipboardMimeTypes(nuint* num_mime_types);
    }
}
