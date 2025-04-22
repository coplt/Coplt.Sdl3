using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Thread
    {
    }

    public enum SDL_ThreadPriority
    {
        SDL_THREAD_PRIORITY_LOW,
        SDL_THREAD_PRIORITY_NORMAL,
        SDL_THREAD_PRIORITY_HIGH,
        SDL_THREAD_PRIORITY_TIME_CRITICAL,
    }

    public enum SDL_ThreadState
    {
        SDL_THREAD_UNKNOWN,
        SDL_THREAD_ALIVE,
        SDL_THREAD_DETACHED,
        SDL_THREAD_COMPLETE,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadRuntime", ExactSpelling = true)]
        public static extern SDL_Thread* CreateThreadRuntime([NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged[Cdecl]<void*, int> fn, [NativeTypeName("const char *")] byte* name, void* data, [NativeTypeName("SDL_FunctionPointer")] delegate* unmanaged[Cdecl]<void> pfnBeginThread, [NativeTypeName("SDL_FunctionPointer")] delegate* unmanaged[Cdecl]<void> pfnEndThread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadWithPropertiesRuntime", ExactSpelling = true)]
        public static extern SDL_Thread* CreateThreadWithPropertiesRuntime([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("SDL_FunctionPointer")] delegate* unmanaged[Cdecl]<void> pfnBeginThread, [NativeTypeName("SDL_FunctionPointer")] delegate* unmanaged[Cdecl]<void> pfnEndThread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetThreadName(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentThreadID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_ThreadID")]
        public static extern ulong GetCurrentThreadID();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_ThreadID")]
        public static extern ulong GetThreadID(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCurrentThreadPriority", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetCurrentThreadPriority(SDL_ThreadPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitThread", ExactSpelling = true)]
        public static extern void WaitThread(SDL_Thread* thread, int* status);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadState", ExactSpelling = true)]
        public static extern SDL_ThreadState GetThreadState(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachThread", ExactSpelling = true)]
        public static extern void DetachThread(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTLS", ExactSpelling = true)]
        public static extern void* GetTLS([NativeTypeName("SDL_TLSID *")] SDL_AtomicInt* id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTLS", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SetTLS([NativeTypeName("SDL_TLSID *")] SDL_AtomicInt* id, [NativeTypeName("const void *")] void* value, [NativeTypeName("SDL_TLSDestructorCallback")] delegate* unmanaged[Cdecl]<void*, void> destructor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CleanupTLS", ExactSpelling = true)]
        public static extern void CleanupTLS();
    }
}
