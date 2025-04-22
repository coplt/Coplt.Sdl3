using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_HintPriority
    {
        SDL_HINT_DEFAULT,
        SDL_HINT_NORMAL,
        SDL_HINT_OVERRIDE,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHintWithPriority", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetHintWithPriority([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value, SDL_HintPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHint", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetHint([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetHint", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ResetHint([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetHints", ExactSpelling = true)]
        public static extern void ResetHints();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHint", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetHint([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHintBoolean", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetHintBoolean([NativeTypeName("const char *")] byte* name, [NativeTypeName("_Bool")] byte default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddHintCallback", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte AddHintCallback([NativeTypeName("const char *")] byte* name, [NativeTypeName("SDL_HintCallback")] delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveHintCallback", ExactSpelling = true)]
        public static extern void RemoveHintCallback([NativeTypeName("const char *")] byte* name, [NativeTypeName("SDL_HintCallback")] delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> callback, void* userdata);
    }
}
