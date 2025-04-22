using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Process
    {
    }

    public enum SDL_ProcessIO
    {
        SDL_PROCESS_STDIO_INHERITED,
        SDL_PROCESS_STDIO_NULL,
        SDL_PROCESS_STDIO_APP,
        SDL_PROCESS_STDIO_REDIRECT,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProcess", ExactSpelling = true)]
        public static extern SDL_Process* CreateProcess([NativeTypeName("const char *const *")] byte** args, [NativeTypeName("_Bool")] byte pipe_stdio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProcessWithProperties", ExactSpelling = true)]
        public static extern SDL_Process* CreateProcessWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetProcessProperties(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadProcess", ExactSpelling = true)]
        public static extern void* ReadProcess(SDL_Process* process, [NativeTypeName("size_t *")] nuint* datasize, int* exitcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessInput", ExactSpelling = true)]
        public static extern SDL_IOStream* GetProcessInput(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessOutput", ExactSpelling = true)]
        public static extern SDL_IOStream* GetProcessOutput(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_KillProcess", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte KillProcess(SDL_Process* process, [NativeTypeName("_Bool")] byte force);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitProcess", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WaitProcess(SDL_Process* process, [NativeTypeName("_Bool")] byte block, int* exitcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProcess", ExactSpelling = true)]
        public static extern void DestroyProcess(SDL_Process* process);
    }
}
