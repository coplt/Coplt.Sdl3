using System;

namespace Coplt.Sdl3;

[Flags]
public enum SDL_GPUTextureUsageFlags : uint
{
    Sampler = 1u << 0,
    ColorTarget = 1u << 1,
    DepthStencilTarget = 1u << 2,
    GraphicsStorageRead = 1u << 3,
    ComputeStorageRead = 1u << 4,
    ComputeStorageWrite = 1u << 5,
    ComputeStorageSimultaneousReadWrite = 1u << 6,
}

[Flags]
public enum SDL_GPUBufferUsageFlags : uint
{
    Vertex = 1u << 0,
    Index = 1u << 1,
    Indirect = 1u << 2,
    GraphicsStorageRead = 1u << 3,
    ComputeStorageRead = 1u << 4,
    ComputeStorageWrite = 1u << 5,
}

[Flags]
public enum SDL_GPUColorComponentFlags : byte
{
    R = (byte)(1u << 0),
    G = (byte)(1u << 1),
    B = (byte)(1u << 2),
    A = (byte)(1u << 3),
}
