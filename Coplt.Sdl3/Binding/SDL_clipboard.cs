using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardText", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetClipboardText([NativeTypeName("const char *")] byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardText", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* GetClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardText", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte HasClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPrimarySelectionText", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetPrimarySelectionText([NativeTypeName("const char *")] byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimarySelectionText", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* GetPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasPrimarySelectionText", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte HasPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardData", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetClipboardData([NativeTypeName("SDL_ClipboardDataCallback")] delegate* unmanaged[Cdecl]<void*, byte*, nuint*, void*> callback, [NativeTypeName("SDL_ClipboardCleanupCallback")] delegate* unmanaged[Cdecl]<void*, void> cleanup, void* userdata, [NativeTypeName("const char **")] byte** mime_types, [NativeTypeName("size_t")] nuint num_mime_types);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearClipboardData", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ClearClipboardData();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardData", ExactSpelling = true)]
        public static extern void* GetClipboardData([NativeTypeName("const char *")] byte* mime_type, [NativeTypeName("size_t *")] nuint* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardData", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte HasClipboardData([NativeTypeName("const char *")] byte* mime_type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardMimeTypes", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern byte** GetClipboardMimeTypes([NativeTypeName("size_t *")] nuint* num_mime_types);
    }
}
