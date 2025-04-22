using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Point
    {
        public int x;

        public int y;
    }

    public partial struct SDL_FPoint
    {
        public float x;

        public float y;
    }

    public partial struct SDL_Rect
    {
        public int x;

        public int y;

        public int w;

        public int h;
    }

    public partial struct SDL_FRect
    {
        public float x;

        public float y;

        public float w;

        public float h;
    }

    public static unsafe partial class SDL
    {
        public static void RectToFRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_FRect* frect)
        {
            frect->x = (float)(rect->x);
            frect->y = (float)(rect->y);
            frect->w = (float)(rect->w);
            frect->h = (float)(rect->h);
        }

        [return: NativeTypeName("_Bool")]
        public static bool PointInRect([NativeTypeName("const SDL_Point *")] SDL_Point* p, [NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
        {
            return (((p != null) && (r != null) && (p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? 1 : 0) != 0;
        }

        [return: NativeTypeName("_Bool")]
        public static bool RectEmpty([NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
        {
            return (((r == null) || (r->w <= 0) || (r->h <= 0)) ? 1 : 0) != 0;
        }

        [return: NativeTypeName("_Bool")]
        public static bool RectsEqual([NativeTypeName("const SDL_Rect *")] SDL_Rect* a, [NativeTypeName("const SDL_Rect *")] SDL_Rect* b)
        {
            return (((a != null) && (b != null) && (a->x == b->x) && (a->y == b->y) && (a->w == b->w) && (a->h == b->h)) ? 1 : 0) != 0;
        }

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRectIntersection", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte HasRectIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectIntersection", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetRectIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectUnion", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetRectUnion([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectEnclosingPoints", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetRectEnclosingPoints([NativeTypeName("const SDL_Point *")] SDL_Point* points, int count, [NativeTypeName("const SDL_Rect *")] SDL_Rect* clip, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectAndLineIntersection", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetRectAndLineIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

        [return: NativeTypeName("_Bool")]
        public static bool PointInRectFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* p, [NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
        {
            return (((p != null) && (r != null) && (p->x >= r->x) && (p->x <= (r->x + r->w)) && (p->y >= r->y) && (p->y <= (r->y + r->h))) ? 1 : 0) != 0;
        }

        [return: NativeTypeName("_Bool")]
        public static bool RectEmptyFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
        {
            return (((r == null) || (r->w < 0.0f) || (r->h < 0.0f)) ? 1 : 0) != 0;
        }

        [return: NativeTypeName("_Bool")]
        public static bool RectsEqualEpsilon([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b, float epsilon)
        {
            return (((a != null) && (b != null) && ((a == b) || ((fabsf(a->x - b->x) <= epsilon) && (fabsf(a->y - b->y) <= epsilon) && (fabsf(a->w - b->w) <= epsilon) && (fabsf(a->h - b->h) <= epsilon)))) ? 1 : 0) != 0;
        }

        [return: NativeTypeName("_Bool")]
        public static bool RectsEqualFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b)
        {
            return RectsEqualEpsilon(a, b, 1.1920928955078125e-07F);
        }

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRectIntersectionFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte HasRectIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectIntersectionFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetRectIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectUnionFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetRectUnionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectEnclosingPointsFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetRectEnclosingPointsFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count, [NativeTypeName("const SDL_FRect *")] SDL_FRect* clip, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectAndLineIntersectionFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern byte GetRectAndLineIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2);
    }
}
