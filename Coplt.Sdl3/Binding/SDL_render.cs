using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Vertex
    {
        public SDL_FPoint position;

        public SDL_FColor color;

        public SDL_FPoint tex_coord;
    }

    public enum SDL_TextureAccess
    {
        SDL_TEXTUREACCESS_STATIC,
        SDL_TEXTUREACCESS_STREAMING,
        SDL_TEXTUREACCESS_TARGET,
    }

    public enum SDL_RendererLogicalPresentation
    {
        SDL_LOGICAL_PRESENTATION_DISABLED,
        SDL_LOGICAL_PRESENTATION_STRETCH,
        SDL_LOGICAL_PRESENTATION_LETTERBOX,
        SDL_LOGICAL_PRESENTATION_OVERSCAN,
        SDL_LOGICAL_PRESENTATION_INTEGER_SCALE,
    }

    public partial struct SDL_Renderer
    {
    }

    public partial struct SDL_Texture
    {
        public SDL_PixelFormat format;

        public int w;

        public int h;

        public int refcount;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumRenderDrivers", ExactSpelling = true)]
        public static extern int GetNumRenderDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetRenderDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowAndRenderer", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 CreateWindowAndRenderer([NativeTypeName("const char *")] byte* title, int width, int height, [NativeTypeName("SDL_WindowFlags")] ulong window_flags, SDL_Window** window, SDL_Renderer** renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRenderer", ExactSpelling = true)]
        public static extern SDL_Renderer* CreateRenderer(SDL_Window* window, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRendererWithProperties", ExactSpelling = true)]
        public static extern SDL_Renderer* CreateRendererWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSoftwareRenderer", ExactSpelling = true)]
        public static extern SDL_Renderer* CreateSoftwareRenderer(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderer", ExactSpelling = true)]
        public static extern SDL_Renderer* GetRenderer(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderWindow", ExactSpelling = true)]
        public static extern SDL_Window* GetRenderWindow(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetRendererName(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetRendererProperties(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderOutputSize", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentRenderOutputSize", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTexture", ExactSpelling = true)]
        public static extern SDL_Texture* CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureFromSurface", ExactSpelling = true)]
        public static extern SDL_Texture* CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureWithProperties", ExactSpelling = true)]
        public static extern SDL_Texture* CreateTextureWithProperties(SDL_Renderer* renderer, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetTextureProperties(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererFromTexture", ExactSpelling = true)]
        public static extern SDL_Renderer* GetRendererFromTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureSize", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTextureSize(SDL_Texture* texture, float* w, float* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorMod", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorModFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorMod", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorModFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTextureColorModFloat(SDL_Texture* texture, float* r, float* g, float* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaMod", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaModFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetTextureAlphaModFloat(SDL_Texture* texture, float alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaMod", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaModFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetTextureBlendMode(SDL_Texture* texture, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTextureBlendMode(SDL_Texture* texture, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureScaleMode", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureScaleMode", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateTexture", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 UpdateTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const void *")] void* pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateYUVTexture", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 UpdateYUVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* Uplane, int Upitch, [NativeTypeName("const Uint8 *")] byte* Vplane, int Vpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateNVTexture", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 UpdateNVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* UVplane, int UVpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTexture", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 LockTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, void** pixels, int* pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTextureToSurface", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 LockTextureToSurface(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_Surface** surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockTexture", ExactSpelling = true)]
        public static extern void UnlockTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderTarget", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderTarget", ExactSpelling = true)]
        public static extern SDL_Texture* GetRenderTarget(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderLogicalPresentation", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderLogicalPresentation", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderLogicalPresentation(SDL_Renderer* renderer, int* w, int* h, SDL_RendererLogicalPresentation* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderLogicalPresentationRect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderLogicalPresentationRect(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCoordinatesFromWindow", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCoordinatesToWindow", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* window_x, float* window_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertEventToRenderCoordinates", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderViewport", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderViewport(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderViewport", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderViewportSet", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderViewportSet(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderSafeArea", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderSafeArea(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderClipRect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderClipRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderClipRect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClipEnabled", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderClipEnabled(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderScale", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderScale", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColor", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColorFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColor", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColorFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderDrawColorFloat(SDL_Renderer* renderer, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderColorScale", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderColorScale(SDL_Renderer* renderer, float scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderColorScale", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderColorScale(SDL_Renderer* renderer, float* scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderDrawBlendMode(SDL_Renderer* renderer, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderDrawBlendMode(SDL_Renderer* renderer, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClear", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderClear(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPoint", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderPoint(SDL_Renderer* renderer, float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPoints", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderPoints(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLine", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLines", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderLines(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderRect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderRects", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderFillRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRects", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderFillRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureRotated", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, double angle, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* center, SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureAffine", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderTextureAffine(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* origin, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* right, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureTiled", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderTextureTiled(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture9Grid", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderTexture9Grid(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometry", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Vertex *")] SDL_Vertex* vertices, int num_vertices, [NativeTypeName("const int *")] int* indices, int num_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometryRaw", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const float *")] float* xy, int xy_stride, [NativeTypeName("const SDL_FColor *")] SDL_FColor* color, int color_stride, [NativeTypeName("const float *")] float* uv, int uv_stride, int num_vertices, [NativeTypeName("const void *")] void* indices, int num_indices, int size_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderReadPixels", ExactSpelling = true)]
        public static extern SDL_Surface* RenderReadPixels(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPresent", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderPresent(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyTexture", ExactSpelling = true)]
        public static extern void DestroyTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyRenderer", ExactSpelling = true)]
        public static extern void DestroyRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushRenderer", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 FlushRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderMetalLayer", ExactSpelling = true)]
        public static extern void* GetRenderMetalLayer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderMetalCommandEncoder", ExactSpelling = true)]
        public static extern void* GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddVulkanRenderSemaphores", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 AddVulkanRenderSemaphores(SDL_Renderer* renderer, [NativeTypeName("Uint32")] uint wait_stage_mask, [NativeTypeName("Sint64")] long wait_semaphore, [NativeTypeName("Sint64")] long signal_semaphore);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderVSync", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetRenderVSync(SDL_Renderer* renderer, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderVSync", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetRenderVSync(SDL_Renderer* renderer, int* vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDebugText", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderDebugText(SDL_Renderer* renderer, float x, float y, [NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDebugTextFormat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 RenderDebugTextFormat(SDL_Renderer* renderer, float x, float y, [NativeTypeName("const char *")] byte* fmt, __arglist);
    }
}
