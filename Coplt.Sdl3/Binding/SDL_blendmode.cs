using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_BlendOperation
    {
        Add = 0x1,
        Subtract = 0x2,
        RevSubtract = 0x3,
        Minimum = 0x4,
        Maximum = 0x5,
    }

    public enum SDL_BlendFactor
    {
        Zero = 0x1,
        One = 0x2,
        SrcColor = 0x3,
        OneMinusSrcColor = 0x4,
        SrcAlpha = 0x5,
        OneMinusSrcAlpha = 0x6,
        DstColor = 0x7,
        OneMinusDstColor = 0x8,
        DstAlpha = 0x9,
        OneMinusDstAlpha = 0xA,
    }

    public static partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ComposeCustomBlendMode", ExactSpelling = true)]
        public static extern SDL_BlendMode ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);
    }
}
