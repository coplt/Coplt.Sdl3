using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_AtomicInt
    {
        public int value;
    }

    public partial struct SDL_AtomicU32
    {
        public uint value;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockSpinlock", ExactSpelling = true)]
        public static extern bool8 TryLockSpinlock(int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockSpinlock", ExactSpelling = true)]
        public static extern void LockSpinlock(int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockSpinlock", ExactSpelling = true)]
        public static extern void UnlockSpinlock(int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MemoryBarrierReleaseFunction", ExactSpelling = true)]
        public static extern void MemoryBarrierReleaseFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MemoryBarrierAcquireFunction", ExactSpelling = true)]
        public static extern void MemoryBarrierAcquireFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicInt", ExactSpelling = true)]
        public static extern bool8 CompareAndSwapAtomicInt(SDL_AtomicInt* a, int oldval, int newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicInt", ExactSpelling = true)]
        public static extern int SetAtomicInt(SDL_AtomicInt* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicInt", ExactSpelling = true)]
        public static extern int GetAtomicInt(SDL_AtomicInt* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddAtomicInt", ExactSpelling = true)]
        public static extern int AddAtomicInt(SDL_AtomicInt* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicU32", ExactSpelling = true)]
        public static extern bool8 CompareAndSwapAtomicU32(SDL_AtomicU32* a,uint oldval,uint newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicU32", ExactSpelling = true)]
        public static extern uint SetAtomicU32(SDL_AtomicU32* a,uint v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicU32", ExactSpelling = true)]
        public static extern uint GetAtomicU32(SDL_AtomicU32* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicPointer", ExactSpelling = true)]
        public static extern bool8 CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicPointer", ExactSpelling = true)]
        public static extern void* SetAtomicPointer(void** a, void* v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicPointer", ExactSpelling = true)]
        public static extern void* GetAtomicPointer(void** a);
    }
}
