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
        public static extern bool8 SetHintWithPriority(byte* name,byte* value, SDL_HintPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHint", ExactSpelling = true)]
        public static extern bool8 SetHint(byte* name,byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetHint", ExactSpelling = true)]
        public static extern bool8 ResetHint(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetHints", ExactSpelling = true)]
        public static extern void ResetHints();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHint", ExactSpelling = true)]
        public static extern byte* GetHint(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHintBoolean", ExactSpelling = true)]
        public static extern bool8 GetHintBoolean(byte* name,bool8 default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddHintCallback", ExactSpelling = true)]
        public static extern bool8 AddHintCallback(byte* name,delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveHintCallback", ExactSpelling = true)]
        public static extern void RemoveHintCallback(byte* name,delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> callback, void* userdata);
    }
}
