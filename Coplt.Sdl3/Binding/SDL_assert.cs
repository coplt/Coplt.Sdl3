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
        [NativeTypeName("_Bool")]
        public byte always_ignore;

        [NativeTypeName("unsigned int")]
        public uint trigger_count;

        [NativeTypeName("const char *")]
        public byte* condition;

        [NativeTypeName("const char *")]
        public byte* filename;

        public int linenum;

        [NativeTypeName("const char *")]
        public byte* function;

        [NativeTypeName("const struct SDL_AssertData *")]
        public SDL_AssertData* next;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReportAssertion", ExactSpelling = true)]
        public static extern SDL_AssertState ReportAssertion(SDL_AssertData* data, [NativeTypeName("const char *")] byte* func, [NativeTypeName("const char *")] byte* file, int line);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAssertionHandler", ExactSpelling = true)]
        public static extern void SetAssertionHandler([NativeTypeName("SDL_AssertionHandler")] delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> handler, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultAssertionHandler", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AssertionHandler")]
        public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetDefaultAssertionHandler();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionHandler", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AssertionHandler")]
        public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetAssertionHandler(void** puserdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionReport", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_AssertData *")]
        public static extern SDL_AssertData* GetAssertionReport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetAssertionReport", ExactSpelling = true)]
        public static extern void ResetAssertionReport();
    }
}
