using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_AssertState
    {
        SDL_ASSERTION_RETRY,
        SDL_ASSERTION_BREAK,
        SDL_ASSERTION_ABORT,
        SDL_ASSERTION_IGNORE,
        SDL_ASSERTION_ALWAYS_IGNORE,
    }

    public unsafe partial struct SDL_AssertData
    {
        public bool8 always_ignore;
        public uint trigger_count;
        public byte* condition;
        public byte* filename;

        public int linenum;
        public byte* function;
        public SDL_AssertData* next;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReportAssertion", ExactSpelling = true)]
        public static extern SDL_AssertState ReportAssertion(SDL_AssertData* data,byte* func,byte* file, int line);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAssertionHandler", ExactSpelling = true)]
        public static extern void SetAssertionHandler(delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> handler, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultAssertionHandler", ExactSpelling = true)]
        public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetDefaultAssertionHandler();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionHandler", ExactSpelling = true)]
        public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetAssertionHandler(void** puserdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionReport", ExactSpelling = true)]
        public static extern SDL_AssertData* GetAssertionReport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetAssertionReport", ExactSpelling = true)]
        public static extern void ResetAssertionReport();
    }
}
