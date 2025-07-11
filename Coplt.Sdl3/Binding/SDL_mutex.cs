using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Mutex
    {
    }

    public partial struct SDL_RWLock
    {
    }

    public partial struct SDL_Semaphore
    {
    }

    public partial struct SDL_Condition
    {
    }

    public enum SDL_InitStatus
    {
        StatusUninitialized,
        StatusInitializing,
        StatusInitialized,
        StatusUninitializing,
    }

    public unsafe partial struct SDL_InitState
    {
        public SDL_AtomicInt status;

        public SDL_ThreadID thread;

        public void* reserved;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateMutex", ExactSpelling = true)]
        public static extern SDL_Mutex* CreateMutex();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockMutex", ExactSpelling = true)]
        public static extern void LockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockMutex", ExactSpelling = true)]
        public static extern bool8 TryLockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockMutex", ExactSpelling = true)]
        public static extern void UnlockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyMutex", ExactSpelling = true)]
        public static extern void DestroyMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRWLock", ExactSpelling = true)]
        public static extern SDL_RWLock* CreateRWLock();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockRWLockForReading", ExactSpelling = true)]
        public static extern void LockRWLockForReading(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockRWLockForWriting", ExactSpelling = true)]
        public static extern void LockRWLockForWriting(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockRWLockForReading", ExactSpelling = true)]
        public static extern bool8 TryLockRWLockForReading(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockRWLockForWriting", ExactSpelling = true)]
        public static extern bool8 TryLockRWLockForWriting(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockRWLock", ExactSpelling = true)]
        public static extern void UnlockRWLock(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyRWLock", ExactSpelling = true)]
        public static extern void DestroyRWLock(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSemaphore", ExactSpelling = true)]
        public static extern SDL_Semaphore* CreateSemaphore(uint initial_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroySemaphore", ExactSpelling = true)]
        public static extern void DestroySemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitSemaphore", ExactSpelling = true)]
        public static extern void WaitSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryWaitSemaphore", ExactSpelling = true)]
        public static extern bool8 TryWaitSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitSemaphoreTimeout", ExactSpelling = true)]
        public static extern bool8 WaitSemaphoreTimeout(SDL_Semaphore* sem,int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalSemaphore", ExactSpelling = true)]
        public static extern void SignalSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSemaphoreValue", ExactSpelling = true)]
        public static extern uint GetSemaphoreValue(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateCondition", ExactSpelling = true)]
        public static extern SDL_Condition* CreateCondition();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyCondition", ExactSpelling = true)]
        public static extern void DestroyCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalCondition", ExactSpelling = true)]
        public static extern void SignalCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BroadcastCondition", ExactSpelling = true)]
        public static extern void BroadcastCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitCondition", ExactSpelling = true)]
        public static extern void WaitCondition(SDL_Condition* cond, SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitConditionTimeout", ExactSpelling = true)]
        public static extern bool8 WaitConditionTimeout(SDL_Condition* cond, SDL_Mutex* mutex,int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShouldInit", ExactSpelling = true)]
        public static extern bool8 ShouldInit(SDL_InitState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShouldQuit", ExactSpelling = true)]
        public static extern bool8 ShouldQuit(SDL_InitState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetInitialized", ExactSpelling = true)]
        public static extern void SetInitialized(SDL_InitState* state,bool8 initialized);
    }
}
