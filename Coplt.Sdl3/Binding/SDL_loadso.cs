using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_SharedObject
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadObject", ExactSpelling = true)]
        public static extern SDL_SharedObject* LoadObject(byte* sofile);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFunction", ExactSpelling = true)]
        public static extern delegate* unmanaged[Cdecl]<void> LoadFunction(SDL_SharedObject* handle,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnloadObject", ExactSpelling = true)]
        public static extern void UnloadObject(SDL_SharedObject* handle);
    }
}
