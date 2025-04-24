using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_LogCategory
    {
        CategoryApplication,
        CategoryError,
        CategoryAssert,
        CategorySystem,
        CategoryAudio,
        CategoryVideo,
        CategoryRender,
        CategoryInput,
        CategoryTest,
        CategoryGpu,
        CategoryReserved2,
        CategoryReserved3,
        CategoryReserved4,
        CategoryReserved5,
        CategoryReserved6,
        CategoryReserved7,
        CategoryReserved8,
        CategoryReserved9,
        CategoryReserved10,
        CategoryCustom,
    }

    public enum SDL_LogPriority
    {
        PriorityInvalid,
        PriorityTrace,
        PriorityVerbose,
        PriorityDebug,
        PriorityInfo,
        PriorityWarn,
        PriorityError,
        PriorityCritical,
        PriorityCount,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriorities", ExactSpelling = true)]
        public static extern void SetLogPriorities(SDL_LogPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriority", ExactSpelling = true)]
        public static extern void SetLogPriority(int category, SDL_LogPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetLogPriority", ExactSpelling = true)]
        public static extern SDL_LogPriority GetLogPriority(int category);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetLogPriorities", ExactSpelling = true)]
        public static extern void ResetLogPriorities();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriorityPrefix", ExactSpelling = true)]
        public static extern bool8 SetLogPriorityPrefix(SDL_LogPriority priority,byte* prefix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Log", ExactSpelling = true)]
        public static extern void Log(byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogTrace", ExactSpelling = true)]
        public static extern void LogTrace(int category,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogVerbose", ExactSpelling = true)]
        public static extern void LogVerbose(int category,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogDebug", ExactSpelling = true)]
        public static extern void LogDebug(int category,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogInfo", ExactSpelling = true)]
        public static extern void LogInfo(int category,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogWarn", ExactSpelling = true)]
        public static extern void LogWarn(int category,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogError", ExactSpelling = true)]
        public static extern void LogError(int category,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogCritical", ExactSpelling = true)]
        public static extern void LogCritical(int category,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogMessage", ExactSpelling = true)]
        public static extern void LogMessage(int category, SDL_LogPriority priority,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogMessageV", ExactSpelling = true)]
        public static extern void LogMessageV(int category, SDL_LogPriority priority,byte* fmt,byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultLogOutputFunction", ExactSpelling = true)]
        public static extern delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, byte*, void> GetDefaultLogOutputFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetLogOutputFunction", ExactSpelling = true)]
        public static extern void GetLogOutputFunction(delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, byte*, void>* callback, void** userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogOutputFunction", ExactSpelling = true)]
        public static extern void SetLogOutputFunction(delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, byte*, void> callback, void* userdata);
    }
}
