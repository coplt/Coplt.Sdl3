using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Thread
    {
    }

    public enum SDL_ThreadPriority
    {
        PriorityLow,
        PriorityNormal,
        PriorityHigh,
        PriorityTimeCritical,
    }

    public enum SDL_ThreadState
    {
        Unknown,
        Alive,
        Detached,
        Complete,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadRuntime", ExactSpelling = true)]
        public static extern SDL_Thread* CreateThreadRuntime(delegate* unmanaged[Cdecl]<void*, int> fn,byte* name, void* data,delegate* unmanaged[Cdecl]<void> pfnBeginThread,delegate* unmanaged[Cdecl]<void> pfnEndThread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadWithPropertiesRuntime", ExactSpelling = true)]
        public static extern SDL_Thread* CreateThreadWithPropertiesRuntime(SDL_PropertiesID props,delegate* unmanaged[Cdecl]<void> pfnBeginThread,delegate* unmanaged[Cdecl]<void> pfnEndThread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadName", ExactSpelling = true)]
        public static extern byte* GetThreadName(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentThreadID", ExactSpelling = true)]
        public static extern SDL_ThreadID GetCurrentThreadID();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadID", ExactSpelling = true)]
        public static extern SDL_ThreadID GetThreadID(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCurrentThreadPriority", ExactSpelling = true)]
        public static extern bool8 SetCurrentThreadPriority(SDL_ThreadPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitThread", ExactSpelling = true)]
        public static extern void WaitThread(SDL_Thread* thread, int* status);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadState", ExactSpelling = true)]
        public static extern SDL_ThreadState GetThreadState(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachThread", ExactSpelling = true)]
        public static extern void DetachThread(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTLS", ExactSpelling = true)]
        public static extern void* GetTLS(SDL_AtomicInt* id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTLS", ExactSpelling = true)]
        public static extern bool8 SetTLS(SDL_AtomicInt* id,void* value,delegate* unmanaged[Cdecl]<void*, void> destructor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CleanupTLS", ExactSpelling = true)]
        public static extern void CleanupTLS();
    }
}
