using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_IOStatus
    {
        SDL_IO_STATUS_READY,
        SDL_IO_STATUS_ERROR,
        SDL_IO_STATUS_EOF,
        SDL_IO_STATUS_NOT_READY,
        SDL_IO_STATUS_READONLY,
        SDL_IO_STATUS_WRITEONLY,
    }

    public enum SDL_IOWhence
    {
        SDL_IO_SEEK_SET,
        SDL_IO_SEEK_CUR,
        SDL_IO_SEEK_END,
    }

    public unsafe partial struct SDL_IOStreamInterface
    {
        [NativeTypeName("Uint32")]
        public uint version;

        [NativeTypeName("Sint64 (*)(void *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, long> size;

        [NativeTypeName("Sint64 (*)(void *, Sint64, SDL_IOWhence) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, long, SDL_IOWhence, long> seek;

        [NativeTypeName("size_t (*)(void *, void *, size_t, SDL_IOStatus *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, void*, nuint, SDL_IOStatus*, nuint> read;

        [NativeTypeName("size_t (*)(void *, const void *, size_t, SDL_IOStatus *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, void*, nuint, SDL_IOStatus*, nuint> write;

        [NativeTypeName("_Bool (*)(void *, SDL_IOStatus *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, SDL_IOStatus*, byte> flush;

        [NativeTypeName("_Bool (*)(void *) __attribute__((cdecl))")]
        public delegate* unmanaged[Cdecl]<void*, byte> close;
    }

    public partial struct SDL_IOStream
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromFile", ExactSpelling = true)]
        public static extern SDL_IOStream* IOFromFile([NativeTypeName("const char *")] byte* file, [NativeTypeName("const char *")] byte* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromMem", ExactSpelling = true)]
        public static extern SDL_IOStream* IOFromMem(void* mem, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromConstMem", ExactSpelling = true)]
        public static extern SDL_IOStream* IOFromConstMem([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromDynamicMem", ExactSpelling = true)]
        public static extern SDL_IOStream* IOFromDynamicMem();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenIO", ExactSpelling = true)]
        public static extern SDL_IOStream* OpenIO([NativeTypeName("const SDL_IOStreamInterface *")] SDL_IOStreamInterface* iface, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseIO", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte CloseIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetIOProperties(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOStatus", ExactSpelling = true)]
        public static extern SDL_IOStatus GetIOStatus(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOSize", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern long GetIOSize(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SeekIO", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern long SeekIO(SDL_IOStream* context, [NativeTypeName("Sint64")] long offset, SDL_IOWhence whence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TellIO", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern long TellIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadIO", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint ReadIO(SDL_IOStream* context, void* ptr, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteIO", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint WriteIO(SDL_IOStream* context, [NativeTypeName("const void *")] void* ptr, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOprintf", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint IOprintf(SDL_IOStream* context, [NativeTypeName("const char *")] byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOvprintf", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint IOvprintf(SDL_IOStream* context, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushIO", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte FlushIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile_IO", ExactSpelling = true)]
        public static extern void* LoadFile_IO(SDL_IOStream* src, [NativeTypeName("size_t *")] nuint* datasize, [NativeTypeName("_Bool")] byte closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile", ExactSpelling = true)]
        public static extern void* LoadFile([NativeTypeName("const char *")] byte* file, [NativeTypeName("size_t *")] nuint* datasize);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveFile_IO", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SaveFile_IO(SDL_IOStream* src, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint datasize, [NativeTypeName("_Bool")] byte closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveFile", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte SaveFile([NativeTypeName("const char *")] byte* file, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint datasize);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU8", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadU8(SDL_IOStream* src, [NativeTypeName("Uint8 *")] byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS8", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadS8(SDL_IOStream* src, [NativeTypeName("Sint8 *")] sbyte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU16LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadU16LE(SDL_IOStream* src, [NativeTypeName("Uint16 *")] ushort* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS16LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadS16LE(SDL_IOStream* src, [NativeTypeName("Sint16 *")] short* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU16BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadU16BE(SDL_IOStream* src, [NativeTypeName("Uint16 *")] ushort* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS16BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadS16BE(SDL_IOStream* src, [NativeTypeName("Sint16 *")] short* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU32LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadU32LE(SDL_IOStream* src, [NativeTypeName("Uint32 *")] uint* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS32LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadS32LE(SDL_IOStream* src, [NativeTypeName("Sint32 *")] int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU32BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadU32BE(SDL_IOStream* src, [NativeTypeName("Uint32 *")] uint* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS32BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadS32BE(SDL_IOStream* src, [NativeTypeName("Sint32 *")] int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU64LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadU64LE(SDL_IOStream* src, [NativeTypeName("Uint64 *")] ulong* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS64LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadS64LE(SDL_IOStream* src, [NativeTypeName("Sint64 *")] long* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU64BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadU64BE(SDL_IOStream* src, [NativeTypeName("Uint64 *")] ulong* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS64BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte ReadS64BE(SDL_IOStream* src, [NativeTypeName("Sint64 *")] long* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU8", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteU8(SDL_IOStream* dst, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS8", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteS8(SDL_IOStream* dst, [NativeTypeName("Sint8")] sbyte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU16LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteU16LE(SDL_IOStream* dst, [NativeTypeName("Uint16")] ushort value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS16LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteS16LE(SDL_IOStream* dst, [NativeTypeName("Sint16")] short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU16BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteU16BE(SDL_IOStream* dst, [NativeTypeName("Uint16")] ushort value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS16BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteS16BE(SDL_IOStream* dst, [NativeTypeName("Sint16")] short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU32LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteU32LE(SDL_IOStream* dst, [NativeTypeName("Uint32")] uint value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS32LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteS32LE(SDL_IOStream* dst, [NativeTypeName("Sint32")] int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU32BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteU32BE(SDL_IOStream* dst, [NativeTypeName("Uint32")] uint value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS32BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteS32BE(SDL_IOStream* dst, [NativeTypeName("Sint32")] int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU64LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteU64LE(SDL_IOStream* dst, [NativeTypeName("Uint64")] ulong value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS64LE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteS64LE(SDL_IOStream* dst, [NativeTypeName("Sint64")] long value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU64BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteU64BE(SDL_IOStream* dst, [NativeTypeName("Uint64")] ulong value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS64BE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte WriteS64BE(SDL_IOStream* dst, [NativeTypeName("Sint64")] long value);
    }
}
