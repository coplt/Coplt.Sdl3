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
        public static void RectToFRect(SDL_Rect* rect, SDL_FRect* frect)
        {
            frect->x = (float)(rect->x);
            frect->y = (float)(rect->y);
            frect->w = (float)(rect->w);
            frect->h = (float)(rect->h);
        }
        public static bool8 PointInRect(SDL_Point* p,SDL_Rect* r)
        {
            return (((p != null) && (r != null) && (p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? 1 : 0) != 0;
        }
        public static bool8 RectEmpty(SDL_Rect* r)
        {
            return (((r == null) || (r->w <= 0) || (r->h <= 0)) ? 1 : 0) != 0;
        }
        public static bool8 RectsEqual(SDL_Rect* a,SDL_Rect* b)
        {
            return (((a != null) && (b != null) && (a->x == b->x) && (a->y == b->y) && (a->w == b->w) && (a->h == b->h)) ? 1 : 0) != 0;
        }

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRectIntersection", ExactSpelling = true)]
        public static extern bool8 HasRectIntersection(SDL_Rect* A,SDL_Rect* B);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectIntersection", ExactSpelling = true)]
        public static extern bool8 GetRectIntersection(SDL_Rect* A,SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectUnion", ExactSpelling = true)]
        public static extern bool8 GetRectUnion(SDL_Rect* A,SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectEnclosingPoints", ExactSpelling = true)]
        public static extern bool8 GetRectEnclosingPoints(SDL_Point* points, int count,SDL_Rect* clip, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectAndLineIntersection", ExactSpelling = true)]
        public static extern bool8 GetRectAndLineIntersection(SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2);
        public static bool8 PointInRectFloat(SDL_FPoint* p,SDL_FRect* r)
        {
            return (((p != null) && (r != null) && (p->x >= r->x) && (p->x <= (r->x + r->w)) && (p->y >= r->y) && (p->y <= (r->y + r->h))) ? 1 : 0) != 0;
        }
        public static bool8 RectEmptyFloat(SDL_FRect* r)
        {
            return (((r == null) || (r->w < 0.0f) || (r->h < 0.0f)) ? 1 : 0) != 0;
        }
        public static bool8 RectsEqualEpsilon(SDL_FRect* a,SDL_FRect* b, float epsilon)
        {
            return (((a != null) && (b != null) && ((a == b) || ((fabsf(a->x - b->x) <= epsilon) && (fabsf(a->y - b->y) <= epsilon) && (fabsf(a->w - b->w) <= epsilon) && (fabsf(a->h - b->h) <= epsilon)))) ? 1 : 0) != 0;
        }
        public static bool8 RectsEqualFloat(SDL_FRect* a,SDL_FRect* b)
        {
            return RectsEqualEpsilon(a, b, 1.1920928955078125e-07F);
        }

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRectIntersectionFloat", ExactSpelling = true)]
        public static extern bool8 HasRectIntersectionFloat(SDL_FRect* A,SDL_FRect* B);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectIntersectionFloat", ExactSpelling = true)]
        public static extern bool8 GetRectIntersectionFloat(SDL_FRect* A,SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectUnionFloat", ExactSpelling = true)]
        public static extern bool8 GetRectUnionFloat(SDL_FRect* A,SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectEnclosingPointsFloat", ExactSpelling = true)]
        public static extern bool8 GetRectEnclosingPointsFloat(SDL_FPoint* points, int count,SDL_FRect* clip, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectAndLineIntersectionFloat", ExactSpelling = true)]
        public static extern bool8 GetRectAndLineIntersectionFloat(SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2);
    }
}
