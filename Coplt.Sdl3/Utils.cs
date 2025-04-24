using System;
using System.Runtime.CompilerServices;

namespace Coplt.Sdl3;

public static unsafe partial class SDL
{
    /// <param name="blob">Must be a literal u8 string</param>
    public static byte* StrPtr(ReadOnlySpan<byte> blob) => (byte*)Unsafe.AsPointer(ref Unsafe.AsRef(in blob[0]));
}
