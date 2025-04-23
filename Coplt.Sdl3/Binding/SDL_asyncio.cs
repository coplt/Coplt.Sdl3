using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_AsyncIO
    {
    }

    public enum SDL_AsyncIOTaskType
    {
        SDL_ASYNCIO_TASK_READ,
        SDL_ASYNCIO_TASK_WRITE,
        SDL_ASYNCIO_TASK_CLOSE,
    }

    public enum SDL_AsyncIOResult
    {
        SDL_ASYNCIO_COMPLETE,
        SDL_ASYNCIO_FAILURE,
        SDL_ASYNCIO_CANCELED,
    }

    public unsafe partial struct SDL_AsyncIOOutcome
    {
        public SDL_AsyncIO* asyncio;

        public SDL_AsyncIOTaskType type;

        public SDL_AsyncIOResult result;

        public void* buffer;
        public ulong offset;
        public ulong bytes_requested;
        public ulong bytes_transferred;

        public void* userdata;
    }

    public partial struct SDL_AsyncIOQueue
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AsyncIOFromFile", ExactSpelling = true)]
        public static extern SDL_AsyncIO* AsyncIOFromFile(byte* file,byte* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAsyncIOSize", ExactSpelling = true)]
        public static extern long GetAsyncIOSize(SDL_AsyncIO* asyncio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadAsyncIO", ExactSpelling = true)]
        public static extern bool8 ReadAsyncIO(SDL_AsyncIO* asyncio, void* ptr,ulong offset,ulong size, SDL_AsyncIOQueue* queue, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteAsyncIO", ExactSpelling = true)]
        public static extern bool8 WriteAsyncIO(SDL_AsyncIO* asyncio, void* ptr,ulong offset,ulong size, SDL_AsyncIOQueue* queue, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseAsyncIO", ExactSpelling = true)]
        public static extern bool8 CloseAsyncIO(SDL_AsyncIO* asyncio,bool8 flush, SDL_AsyncIOQueue* queue, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateAsyncIOQueue", ExactSpelling = true)]
        public static extern SDL_AsyncIOQueue* CreateAsyncIOQueue();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyAsyncIOQueue", ExactSpelling = true)]
        public static extern void DestroyAsyncIOQueue(SDL_AsyncIOQueue* queue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAsyncIOResult", ExactSpelling = true)]
        public static extern bool8 GetAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitAsyncIOResult", ExactSpelling = true)]
        public static extern bool8 WaitAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome,int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalAsyncIOQueue", ExactSpelling = true)]
        public static extern void SignalAsyncIOQueue(SDL_AsyncIOQueue* queue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFileAsync", ExactSpelling = true)]
        public static extern bool8 LoadFileAsync(byte* file, SDL_AsyncIOQueue* queue, void* userdata);
    }
}
