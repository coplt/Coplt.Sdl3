using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_ScaleMode
    {
        SDL_SCALEMODE_INVALID = -1,
        SDL_SCALEMODE_NEAREST,
        SDL_SCALEMODE_LINEAR,
    }

    public enum SDL_FlipMode
    {
        SDL_FLIP_NONE,
        SDL_FLIP_HORIZONTAL,
        SDL_FLIP_VERTICAL,
    }

    public unsafe partial struct SDL_Surface
    {
        [NativeTypeName("SDL_SurfaceFlags")]
        public uint flags;

        public SDL_PixelFormat format;

        public int w;

        public int h;

        public int pitch;

        public void* pixels;

        public int refcount;

        public void* reserved;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurface", ExactSpelling = true)]
        public static extern SDL_Surface* CreateSurface(int width, int height, SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurfaceFrom", ExactSpelling = true)]
        public static extern SDL_Surface* CreateSurfaceFrom(int width, int height, SDL_PixelFormat format, void* pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroySurface", ExactSpelling = true)]
        public static extern void DestroySurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetSurfaceProperties(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorspace", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorspace", ExactSpelling = true)]
        public static extern SDL_Colorspace GetSurfaceColorspace(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurfacePalette", ExactSpelling = true)]
        public static extern SDL_Palette* CreateSurfacePalette(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfacePalette", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfacePalette", ExactSpelling = true)]
        public static extern SDL_Palette* GetSurfacePalette(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddSurfaceAlternateImage", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 AddSurfaceAlternateImage(SDL_Surface* surface, SDL_Surface* image);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasAlternateImages", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SurfaceHasAlternateImages(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceImages", ExactSpelling = true)]
        public static extern SDL_Surface** GetSurfaceImages(SDL_Surface* surface, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveSurfaceAlternateImages", ExactSpelling = true)]
        public static extern void RemoveSurfaceAlternateImages(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockSurface", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 LockSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockSurface", ExactSpelling = true)]
        public static extern void UnlockSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadBMP_IO", ExactSpelling = true)]
        public static extern SDL_Surface* LoadBMP_IO(SDL_IOStream* src, [NativeTypeName("_Bool")] bool8 closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadBMP", ExactSpelling = true)]
        public static extern SDL_Surface* LoadBMP([NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveBMP_IO", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SaveBMP_IO(SDL_Surface* surface, SDL_IOStream* dst, [NativeTypeName("_Bool")] bool8 closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveBMP", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SaveBMP(SDL_Surface* surface, [NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceRLE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetSurfaceRLE(SDL_Surface* surface, [NativeTypeName("_Bool")] bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasRLE", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SurfaceHasRLE(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorKey", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("_Bool")] bool8 enabled, [NativeTypeName("Uint32")] uint key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasColorKey", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SurfaceHasColorKey(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorKey", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorMod", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorMod", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceAlphaMod", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceAlphaMod", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetSurfaceBlendMode(SDL_Surface* surface, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceBlendMode", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetSurfaceBlendMode(SDL_Surface* surface, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceClipRect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetSurfaceClipRect(SDL_Surface* surface, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceClipRect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlipSurface", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 FlipSurface(SDL_Surface* surface, SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DuplicateSurface", ExactSpelling = true)]
        public static extern SDL_Surface* DuplicateSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScaleSurface", ExactSpelling = true)]
        public static extern SDL_Surface* ScaleSurface(SDL_Surface* surface, int width, int height, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertSurface", ExactSpelling = true)]
        public static extern SDL_Surface* ConvertSurface(SDL_Surface* surface, SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertSurfaceAndColorspace", ExactSpelling = true)]
        public static extern SDL_Surface* ConvertSurfaceAndColorspace(SDL_Surface* surface, SDL_PixelFormat format, SDL_Palette* palette, SDL_Colorspace colorspace, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertPixels", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ConvertPixels(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, void* dst, int dst_pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertPixelsAndColorspace", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ConvertPixelsAndColorspace(int width, int height, SDL_PixelFormat src_format, SDL_Colorspace src_colorspace, [NativeTypeName("SDL_PropertiesID")] uint src_properties, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, SDL_Colorspace dst_colorspace, [NativeTypeName("SDL_PropertiesID")] uint dst_properties, void* dst, int dst_pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PremultiplyAlpha", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 PremultiplyAlpha(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, void* dst, int dst_pitch, [NativeTypeName("_Bool")] bool8 linear);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PremultiplySurfaceAlpha", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 PremultiplySurfaceAlpha(SDL_Surface* surface, [NativeTypeName("_Bool")] bool8 linear);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearSurface", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ClearSurface(SDL_Surface* surface, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FillSurfaceRect", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 FillSurfaceRect(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FillSurfaceRects", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 FillSurfaceRects(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurface", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BlitSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceUnchecked", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BlitSurfaceUnchecked(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceScaled", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BlitSurfaceScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceUncheckedScaled", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BlitSurfaceUncheckedScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StretchSurface", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 StretchSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceTiled", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BlitSurfaceTiled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceTiledWithScale", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BlitSurfaceTiledWithScale(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurface9Grid", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BlitSurface9Grid(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, int left_width, int right_width, int top_height, int bottom_height, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapSurfaceRGB", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint MapSurfaceRGB(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapSurfaceRGBA", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint MapSurfaceRGBA(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadSurfacePixel", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ReadSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadSurfacePixelFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ReadSurfacePixelFloat(SDL_Surface* surface, int x, int y, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteSurfacePixel", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 WriteSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteSurfacePixelFloat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 WriteSurfacePixelFloat(SDL_Surface* surface, int x, int y, float r, float g, float b, float a);
    }
}
