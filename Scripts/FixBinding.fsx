open System
open System.IO
open System.Text.RegularExpressions

[<Struct>]
type FileItems = FileItems of path: string * names: string array

let uint_enums =
    [| FileItems("SDL_audio", [| "SDL_AudioFormat" |])
       FileItems("SDL_pixels", [| "SDL_PixelFormat"; "SDL_Colorspace" |]) |]

for FileItems(file, items) in uint_enums do
    let path = $"./Coplt.Sdl3/Binding/{file}.cs"
    let code = File.ReadAllText(path)
    let items = String.Join("|", items)
    let regex = Regex($"(?<=public enum ({items}))(?<loc>\n)")
    let code = regex.Replace(code, " : uint\n")
    File.WriteAllText(path, code)


let fix_stdinc () =
    let path = $"./Coplt.Sdl3/Binding/SDL_stdinc.cs"
    let mutable code = File.ReadAllText(path)

    let targets =
        [| """

        [return: NativeTypeName("_Bool")]
        public static bool8 size_add_check_overflow_builtin([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
        {
            return ((__builtin_add_overflow(a, b, ret)) ? 1 : 0 == 0) != 0;
        }"""
           """

        [return: NativeTypeName("_Bool")]
        public static bool8 size_mul_check_overflow_builtin([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
        {
            return ((__builtin_mul_overflow(a, b, ret)) ? 1 : 0 == 0) != 0;
        }""" |]
        |> Seq.map _.Replace("\r\n", "\n")

    for target in targets do
        code <- code.Replace(target, "")

    File.WriteAllText(path, code)

fix_stdinc ()

let fix_rect () =
    let path = $"./Coplt.Sdl3/Binding/SDL_rect.cs"
    let mutable code = File.ReadAllText(path)

    let targets =
        [| """public static bool8 PointInRect([NativeTypeName("const SDL_Point *")] SDL_Point* p, [NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
        {
            return ((p && r && (p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? 1 : 0) != 0;
        }""",
           """public static bool8 PointInRect([NativeTypeName("const SDL_Point *")] SDL_Point* p, [NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
        {
            return (((p != null) && (r != null) && (p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? 1 : 0) != 0;
        }"""

           """public static bool8 RectsEqual([NativeTypeName("const SDL_Rect *")] SDL_Rect* a, [NativeTypeName("const SDL_Rect *")] SDL_Rect* b)
        {
            return ((a && b && (a->x == b->x) && (a->y == b->y) && (a->w == b->w) && (a->h == b->h)) ? 1 : 0) != 0;
        }""",
           """public static bool8 RectsEqual([NativeTypeName("const SDL_Rect *")] SDL_Rect* a, [NativeTypeName("const SDL_Rect *")] SDL_Rect* b)
        {
            return (((a != null) && (b != null) && (a->x == b->x) && (a->y == b->y) && (a->w == b->w) && (a->h == b->h)) ? 1 : 0) != 0;
        }"""

           """public static bool8 PointInRectFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* p, [NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
        {
            return ((p && r && (p->x >= r->x) && (p->x <= (r->x + r->w)) && (p->y >= r->y) && (p->y <= (r->y + r->h))) ? 1 : 0) != 0;
        }""",
           """public static bool8 PointInRectFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* p, [NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
        {
            return (((p != null) && (r != null) && (p->x >= r->x) && (p->x <= (r->x + r->w)) && (p->y >= r->y) && (p->y <= (r->y + r->h))) ? 1 : 0) != 0;
        }"""

           """public static bool8 RectsEqualEpsilon([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b, float epsilon)
        {
            return ((a && b && ((a == b) || ((fabsf(a->x - b->x) <= epsilon) && (fabsf(a->y - b->y) <= epsilon) && (fabsf(a->w - b->w) <= epsilon) && (fabsf(a->h - b->h) <= epsilon)))) ? 1 : 0) != 0;
        }""",
           """public static bool8 RectsEqualEpsilon([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b, float epsilon)
        {
            return (((a != null) && (b != null) && ((a == b) || ((fabsf(a->x - b->x) <= epsilon) && (fabsf(a->y - b->y) <= epsilon) && (fabsf(a->w - b->w) <= epsilon) && (fabsf(a->h - b->h) <= epsilon)))) ? 1 : 0) != 0;
        }"""

           |]
        |> Seq.map (fun (a, b) -> (a.Replace("\r\n", "\n"), b.Replace("\r\n", "\n")))

    for a, b in targets do
        code <- code.Replace(a, b)

    File.WriteAllText(path, code)

fix_rect ()

let remove_native_names_regex =
    Regex("\s*\[(return: )?NativeTypeName\(\"[\w\d _&*(),\[\]]*\"\)\] ?")

for path in Directory.GetFiles("./Coplt.Sdl3/Binding") do
    let code = File.ReadAllText(path)
    let code = remove_native_names_regex.Replace(code, "")
    File.WriteAllText(path, code)

// todo fix enum names
