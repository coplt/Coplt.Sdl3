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
        public uint version;
        public delegate* unmanaged[Cdecl]<void*, long> size;
        public delegate* unmanaged[Cdecl]<void*, long, SDL_IOWhence, long> seek;
        public delegate* unmanaged[Cdecl]<void*, void*, nuint, SDL_IOStatus*, nuint> read;
        public delegate* unmanaged[Cdecl]<void*, void*, nuint, SDL_IOStatus*, nuint> write;
        public delegate* unmanaged[Cdecl]<void*, SDL_IOStatus*, bool8> flush;
        public delegate* unmanaged[Cdecl]<void*, bool8> close;
    }

    public partial struct SDL_IOStream
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromFile", ExactSpelling = true)]
        public static extern SDL_IOStream* IOFromFile(byte* file,byte* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromMem", ExactSpelling = true)]
        public static extern SDL_IOStream* IOFromMem(void* mem,nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromConstMem", ExactSpelling = true)]
        public static extern SDL_IOStream* IOFromConstMem(void* mem,nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromDynamicMem", ExactSpelling = true)]
        public static extern SDL_IOStream* IOFromDynamicMem();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenIO", ExactSpelling = true)]
        public static extern SDL_IOStream* OpenIO(SDL_IOStreamInterface* iface, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseIO", ExactSpelling = true)]
        public static extern bool8 CloseIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOProperties", ExactSpelling = true)]
        public static extern SDL_PropertiesID GetIOProperties(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOStatus", ExactSpelling = true)]
        public static extern SDL_IOStatus GetIOStatus(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOSize", ExactSpelling = true)]
        public static extern long GetIOSize(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SeekIO", ExactSpelling = true)]
        public static extern long SeekIO(SDL_IOStream* context,long offset, SDL_IOWhence whence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TellIO", ExactSpelling = true)]
        public static extern long TellIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadIO", ExactSpelling = true)]
        public static extern nuint ReadIO(SDL_IOStream* context, void* ptr,nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteIO", ExactSpelling = true)]
        public static extern nuint WriteIO(SDL_IOStream* context,void* ptr,nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOprintf", ExactSpelling = true)]
        public static extern nuint IOprintf(SDL_IOStream* context,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOvprintf", ExactSpelling = true)]
        public static extern nuint IOvprintf(SDL_IOStream* context,byte* fmt,byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushIO", ExactSpelling = true)]
        public static extern bool8 FlushIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile_IO", ExactSpelling = true)]
        public static extern void* LoadFile_IO(SDL_IOStream* src,nuint* datasize,bool8 closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile", ExactSpelling = true)]
        public static extern void* LoadFile(byte* file,nuint* datasize);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveFile_IO", ExactSpelling = true)]
        public static extern bool8 SaveFile_IO(SDL_IOStream* src,void* data,nuint datasize,bool8 closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveFile", ExactSpelling = true)]
        public static extern bool8 SaveFile(byte* file,void* data,nuint datasize);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU8", ExactSpelling = true)]
        public static extern bool8 ReadU8(SDL_IOStream* src,byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS8", ExactSpelling = true)]
        public static extern bool8 ReadS8(SDL_IOStream* src,sbyte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU16LE", ExactSpelling = true)]
        public static extern bool8 ReadU16LE(SDL_IOStream* src,ushort* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS16LE", ExactSpelling = true)]
        public static extern bool8 ReadS16LE(SDL_IOStream* src,short* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU16BE", ExactSpelling = true)]
        public static extern bool8 ReadU16BE(SDL_IOStream* src,ushort* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS16BE", ExactSpelling = true)]
        public static extern bool8 ReadS16BE(SDL_IOStream* src,short* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU32LE", ExactSpelling = true)]
        public static extern bool8 ReadU32LE(SDL_IOStream* src,uint* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS32LE", ExactSpelling = true)]
        public static extern bool8 ReadS32LE(SDL_IOStream* src,int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU32BE", ExactSpelling = true)]
        public static extern bool8 ReadU32BE(SDL_IOStream* src,uint* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS32BE", ExactSpelling = true)]
        public static extern bool8 ReadS32BE(SDL_IOStream* src,int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU64LE", ExactSpelling = true)]
        public static extern bool8 ReadU64LE(SDL_IOStream* src,ulong* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS64LE", ExactSpelling = true)]
        public static extern bool8 ReadS64LE(SDL_IOStream* src,long* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU64BE", ExactSpelling = true)]
        public static extern bool8 ReadU64BE(SDL_IOStream* src,ulong* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS64BE", ExactSpelling = true)]
        public static extern bool8 ReadS64BE(SDL_IOStream* src,long* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU8", ExactSpelling = true)]
        public static extern bool8 WriteU8(SDL_IOStream* dst,byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS8", ExactSpelling = true)]
        public static extern bool8 WriteS8(SDL_IOStream* dst,sbyte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU16LE", ExactSpelling = true)]
        public static extern bool8 WriteU16LE(SDL_IOStream* dst,ushort value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS16LE", ExactSpelling = true)]
        public static extern bool8 WriteS16LE(SDL_IOStream* dst,short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU16BE", ExactSpelling = true)]
        public static extern bool8 WriteU16BE(SDL_IOStream* dst,ushort value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS16BE", ExactSpelling = true)]
        public static extern bool8 WriteS16BE(SDL_IOStream* dst,short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU32LE", ExactSpelling = true)]
        public static extern bool8 WriteU32LE(SDL_IOStream* dst,uint value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS32LE", ExactSpelling = true)]
        public static extern bool8 WriteS32LE(SDL_IOStream* dst,int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU32BE", ExactSpelling = true)]
        public static extern bool8 WriteU32BE(SDL_IOStream* dst,uint value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS32BE", ExactSpelling = true)]
        public static extern bool8 WriteS32BE(SDL_IOStream* dst,int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU64LE", ExactSpelling = true)]
        public static extern bool8 WriteU64LE(SDL_IOStream* dst,ulong value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS64LE", ExactSpelling = true)]
        public static extern bool8 WriteS64LE(SDL_IOStream* dst,long value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU64BE", ExactSpelling = true)]
        public static extern bool8 WriteU64BE(SDL_IOStream* dst,ulong value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS64BE", ExactSpelling = true)]
        public static extern bool8 WriteS64BE(SDL_IOStream* dst,long value);
    }
}
