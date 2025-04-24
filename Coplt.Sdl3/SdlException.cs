using System;

namespace Coplt.Sdl3;

public unsafe class SdlException : Exception
{
    public SdlException() : base(new string((sbyte*)SDL.GetError())) { }
    public SdlException(Exception inner) : base(new string((sbyte*)SDL.GetError()), inner) { }
}
