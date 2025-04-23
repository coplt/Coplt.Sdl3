using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_GUID
    {
        public _data_e__FixedBuffer data;

        [InlineArray(16)]
        public partial struct _data_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GUIDToString", ExactSpelling = true)]
        public static extern void GUIDToString(SDL_GUID guid,byte* pszGUID, int cbGUID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StringToGUID", ExactSpelling = true)]
        public static extern SDL_GUID StringToGUID(byte* pchGUID);
    }
}
