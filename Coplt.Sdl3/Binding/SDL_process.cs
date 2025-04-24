using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Process
    {
    }

    public enum SDL_ProcessIO
    {
        StdioInherited,
        StdioNull,
        StdioApp,
        StdioRedirect,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProcess", ExactSpelling = true)]
        public static extern SDL_Process* CreateProcess(byte** args,bool8 pipe_stdio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProcessWithProperties", ExactSpelling = true)]
        public static extern SDL_Process* CreateProcessWithProperties(SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessProperties", ExactSpelling = true)]
        public static extern SDL_PropertiesID GetProcessProperties(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadProcess", ExactSpelling = true)]
        public static extern void* ReadProcess(SDL_Process* process,nuint* datasize, int* exitcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessInput", ExactSpelling = true)]
        public static extern SDL_IOStream* GetProcessInput(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessOutput", ExactSpelling = true)]
        public static extern SDL_IOStream* GetProcessOutput(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_KillProcess", ExactSpelling = true)]
        public static extern bool8 KillProcess(SDL_Process* process,bool8 force);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitProcess", ExactSpelling = true)]
        public static extern bool8 WaitProcess(SDL_Process* process,bool8 block, int* exitcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProcess", ExactSpelling = true)]
        public static extern void DestroyProcess(SDL_Process* process);
    }
}
