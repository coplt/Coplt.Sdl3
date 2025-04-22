using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenURL", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte OpenURL([NativeTypeName("const char *")] byte* url);
    }
}
