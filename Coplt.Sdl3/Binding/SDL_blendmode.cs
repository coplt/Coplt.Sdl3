using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_BlendOperation
    {
        SDL_BLENDOPERATION_ADD = 0x1,
        SDL_BLENDOPERATION_SUBTRACT = 0x2,
        SDL_BLENDOPERATION_REV_SUBTRACT = 0x3,
        SDL_BLENDOPERATION_MINIMUM = 0x4,
        SDL_BLENDOPERATION_MAXIMUM = 0x5,
    }

    public enum SDL_BlendFactor
    {
        SDL_BLENDFACTOR_ZERO = 0x1,
        SDL_BLENDFACTOR_ONE = 0x2,
        SDL_BLENDFACTOR_SRC_COLOR = 0x3,
        SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR = 0x4,
        SDL_BLENDFACTOR_SRC_ALPHA = 0x5,
        SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA = 0x6,
        SDL_BLENDFACTOR_DST_COLOR = 0x7,
        SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR = 0x8,
        SDL_BLENDFACTOR_DST_ALPHA = 0x9,
        SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA = 0xA,
    }

    public static partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ComposeCustomBlendMode", ExactSpelling = true)]
        public static extern SDL_BlendMode ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);
    }
}
