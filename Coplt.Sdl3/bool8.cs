namespace Coplt.Sdl3;

public readonly record struct bool8(byte Value)
{
    public static bool operator true(bool8 v) => v.Value != 0;
    public static bool operator false(bool8 v) => v.Value == 0;
    public static implicit operator bool(bool8 v) => v.Value != 0;
    public static implicit operator bool8(bool v) => new(v ? (byte)1 : (byte)0);

    public override string ToString() => this ? "true" : "false";
}
