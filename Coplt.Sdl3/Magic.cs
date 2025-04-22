using System;
using System.Buffers.Binary;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Coplt.Sdl3;

internal static class Magic
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int __builtin_clz(uint x) => BitOperations.LeadingZeroCount(x);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int __builtin_clz(ulong x) => BitOperations.LeadingZeroCount(x);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint __builtin_bswap32(uint x) => BinaryPrimitives.ReverseEndianness(x);
}
