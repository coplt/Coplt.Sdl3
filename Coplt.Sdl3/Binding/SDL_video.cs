using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_SystemTheme
    {
        Unknown,
        Light,
        Dark,
    }

    public partial struct SDL_DisplayModeData
    {
    }

    public unsafe partial struct SDL_DisplayMode
    {
        public SDL_DisplayID displayID;

        public SDL_PixelFormat format;

        public int w;

        public int h;

        public float pixel_density;

        public float refresh_rate;

        public int refresh_rate_numerator;

        public int refresh_rate_denominator;

        public SDL_DisplayModeData* @internal;
    }

    public enum SDL_DisplayOrientation
    {
        Unknown,
        Landscape,
        LandscapeFlipped,
        Portrait,
        PortraitFlipped,
    }

    public partial struct SDL_Window
    {
    }

    public enum SDL_FlashOperation
    {
        Cancel,
        Briefly,
        UntilFocused,
    }

    public partial struct SDL_GLContextState
    {
    }

    public enum SDL_GLAttr
    {
        RedSize,
        GreenSize,
        BlueSize,
        AlphaSize,
        BufferSize,
        Doublebuffer,
        DepthSize,
        StencilSize,
        AccumRedSize,
        AccumGreenSize,
        AccumBlueSize,
        AccumAlphaSize,
        Stereo,
        Multisamplebuffers,
        Multisamplesamples,
        AcceleratedVisual,
        RetainedBacking,
        ContextMajorVersion,
        ContextMinorVersion,
        ContextFlags,
        ContextProfileMask,
        ShareWithCurrentContext,
        FramebufferSrgbCapable,
        ContextReleaseBehavior,
        ContextResetNotification,
        ContextNoError,
        Floatbuffers,
        EglPlatform,
    }

    public enum SDL_HitTestResult
    {
        Normal,
        Draggable,
        ResizeTopleft,
        ResizeTop,
        ResizeTopright,
        ResizeRight,
        ResizeBottomright,
        ResizeBottom,
        ResizeBottomleft,
        ResizeLeft,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumVideoDrivers", ExactSpelling = true)]
        public static extern int GetNumVideoDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVideoDriver", ExactSpelling = true)]
        public static extern byte* GetVideoDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentVideoDriver", ExactSpelling = true)]
        public static extern byte* GetCurrentVideoDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemTheme", ExactSpelling = true)]
        public static extern SDL_SystemTheme GetSystemTheme();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplays", ExactSpelling = true)]
        public static extern SDL_DisplayID* GetDisplays(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimaryDisplay", ExactSpelling = true)]
        public static extern SDL_DisplayID GetPrimaryDisplay();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayProperties", ExactSpelling = true)]
        public static extern SDL_PropertiesID GetDisplayProperties(SDL_DisplayID displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayName", ExactSpelling = true)]
        public static extern byte* GetDisplayName(SDL_DisplayID displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayBounds", ExactSpelling = true)]
        public static extern bool8 GetDisplayBounds(SDL_DisplayID displayID, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayUsableBounds", ExactSpelling = true)]
        public static extern bool8 GetDisplayUsableBounds(SDL_DisplayID displayID, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNaturalDisplayOrientation", ExactSpelling = true)]
        public static extern SDL_DisplayOrientation GetNaturalDisplayOrientation(SDL_DisplayID displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayOrientation", ExactSpelling = true)]
        public static extern SDL_DisplayOrientation GetCurrentDisplayOrientation(SDL_DisplayID displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayContentScale", ExactSpelling = true)]
        public static extern float GetDisplayContentScale(SDL_DisplayID displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFullscreenDisplayModes", ExactSpelling = true)]
        public static extern SDL_DisplayMode** GetFullscreenDisplayModes(SDL_DisplayID displayID, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClosestFullscreenDisplayMode", ExactSpelling = true)]
        public static extern bool8 GetClosestFullscreenDisplayMode(SDL_DisplayID displayID, int w, int h, float refresh_rate,bool8 include_high_density_modes, SDL_DisplayMode* closest);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDesktopDisplayMode", ExactSpelling = true)]
        public static extern SDL_DisplayMode* GetDesktopDisplayMode(SDL_DisplayID displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayMode", ExactSpelling = true)]
        public static extern SDL_DisplayMode* GetCurrentDisplayMode(SDL_DisplayID displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForPoint", ExactSpelling = true)]
        public static extern SDL_DisplayID GetDisplayForPoint(SDL_Point* point);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForRect", ExactSpelling = true)]
        public static extern SDL_DisplayID GetDisplayForRect(SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForWindow", ExactSpelling = true)]
        public static extern SDL_DisplayID GetDisplayForWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelDensity", ExactSpelling = true)]
        public static extern float GetWindowPixelDensity(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowDisplayScale", ExactSpelling = true)]
        public static extern float GetWindowDisplayScale(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreenMode", ExactSpelling = true)]
        public static extern bool8 SetWindowFullscreenMode(SDL_Window* window,SDL_DisplayMode* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFullscreenMode", ExactSpelling = true)]
        public static extern SDL_DisplayMode* GetWindowFullscreenMode(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowICCProfile", ExactSpelling = true)]
        public static extern void* GetWindowICCProfile(SDL_Window* window,nuint* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelFormat", ExactSpelling = true)]
        public static extern SDL_PixelFormat GetWindowPixelFormat(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindows", ExactSpelling = true)]
        public static extern SDL_Window** GetWindows(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
        public static extern SDL_Window* CreateWindow(byte* title, int w, int h, SDL_WindowFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreatePopupWindow", ExactSpelling = true)]
        public static extern SDL_Window* CreatePopupWindow(SDL_Window* parent, int offset_x, int offset_y, int w, int h, SDL_WindowFlags flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowWithProperties", ExactSpelling = true)]
        public static extern SDL_Window* CreateWindowWithProperties(SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowID", ExactSpelling = true)]
        public static extern SDL_WindowID GetWindowID(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFromID", ExactSpelling = true)]
        public static extern SDL_Window* GetWindowFromID(SDL_WindowID id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowParent", ExactSpelling = true)]
        public static extern SDL_Window* GetWindowParent(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowProperties", ExactSpelling = true)]
        public static extern SDL_PropertiesID GetWindowProperties(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFlags", ExactSpelling = true)]
        public static extern SDL_WindowFlags GetWindowFlags(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowTitle", ExactSpelling = true)]
        public static extern bool8 SetWindowTitle(SDL_Window* window,byte* title);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowTitle", ExactSpelling = true)]
        public static extern byte* GetWindowTitle(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowIcon", ExactSpelling = true)]
        public static extern bool8 SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowPosition", ExactSpelling = true)]
        public static extern bool8 SetWindowPosition(SDL_Window* window, int x, int y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPosition", ExactSpelling = true)]
        public static extern bool8 GetWindowPosition(SDL_Window* window, int* x, int* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSize", ExactSpelling = true)]
        public static extern bool8 SetWindowSize(SDL_Window* window, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSize", ExactSpelling = true)]
        public static extern bool8 GetWindowSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSafeArea", ExactSpelling = true)]
        public static extern bool8 GetWindowSafeArea(SDL_Window* window, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAspectRatio", ExactSpelling = true)]
        public static extern bool8 SetWindowAspectRatio(SDL_Window* window, float min_aspect, float max_aspect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowAspectRatio", ExactSpelling = true)]
        public static extern bool8 GetWindowAspectRatio(SDL_Window* window, float* min_aspect, float* max_aspect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowBordersSize", ExactSpelling = true)]
        public static extern bool8 GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSizeInPixels", ExactSpelling = true)]
        public static extern bool8 GetWindowSizeInPixels(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMinimumSize", ExactSpelling = true)]
        public static extern bool8 SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMinimumSize", ExactSpelling = true)]
        public static extern bool8 GetWindowMinimumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMaximumSize", ExactSpelling = true)]
        public static extern bool8 SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMaximumSize", ExactSpelling = true)]
        public static extern bool8 GetWindowMaximumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowBordered", ExactSpelling = true)]
        public static extern bool8 SetWindowBordered(SDL_Window* window,bool8 bordered);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowResizable", ExactSpelling = true)]
        public static extern bool8 SetWindowResizable(SDL_Window* window,bool8 resizable);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAlwaysOnTop", ExactSpelling = true)]
        public static extern bool8 SetWindowAlwaysOnTop(SDL_Window* window,bool8 on_top);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindow", ExactSpelling = true)]
        public static extern bool8 ShowWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideWindow", ExactSpelling = true)]
        public static extern bool8 HideWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RaiseWindow", ExactSpelling = true)]
        public static extern bool8 RaiseWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MaximizeWindow", ExactSpelling = true)]
        public static extern bool8 MaximizeWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MinimizeWindow", ExactSpelling = true)]
        public static extern bool8 MinimizeWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RestoreWindow", ExactSpelling = true)]
        public static extern bool8 RestoreWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreen", ExactSpelling = true)]
        public static extern bool8 SetWindowFullscreen(SDL_Window* window,bool8 fullscreen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SyncWindow", ExactSpelling = true)]
        public static extern bool8 SyncWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowHasSurface", ExactSpelling = true)]
        public static extern bool8 WindowHasSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurface", ExactSpelling = true)]
        public static extern SDL_Surface* GetWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSurfaceVSync", ExactSpelling = true)]
        public static extern bool8 SetWindowSurfaceVSync(SDL_Window* window, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurfaceVSync", ExactSpelling = true)]
        public static extern bool8 GetWindowSurfaceVSync(SDL_Window* window, int* vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurface", ExactSpelling = true)]
        public static extern bool8 UpdateWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurfaceRects", ExactSpelling = true)]
        public static extern bool8 UpdateWindowSurfaceRects(SDL_Window* window,SDL_Rect* rects, int numrects);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindowSurface", ExactSpelling = true)]
        public static extern bool8 DestroyWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowKeyboardGrab", ExactSpelling = true)]
        public static extern bool8 SetWindowKeyboardGrab(SDL_Window* window,bool8 grabbed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseGrab", ExactSpelling = true)]
        public static extern bool8 SetWindowMouseGrab(SDL_Window* window,bool8 grabbed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowKeyboardGrab", ExactSpelling = true)]
        public static extern bool8 GetWindowKeyboardGrab(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseGrab", ExactSpelling = true)]
        public static extern bool8 GetWindowMouseGrab(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGrabbedWindow", ExactSpelling = true)]
        public static extern SDL_Window* GetGrabbedWindow();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseRect", ExactSpelling = true)]
        public static extern bool8 SetWindowMouseRect(SDL_Window* window,SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseRect", ExactSpelling = true)]
        public static extern SDL_Rect* GetWindowMouseRect(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowOpacity", ExactSpelling = true)]
        public static extern bool8 SetWindowOpacity(SDL_Window* window, float opacity);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowOpacity", ExactSpelling = true)]
        public static extern float GetWindowOpacity(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowParent", ExactSpelling = true)]
        public static extern bool8 SetWindowParent(SDL_Window* window, SDL_Window* parent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowModal", ExactSpelling = true)]
        public static extern bool8 SetWindowModal(SDL_Window* window,bool8 modal);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFocusable", ExactSpelling = true)]
        public static extern bool8 SetWindowFocusable(SDL_Window* window,bool8 focusable);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindowSystemMenu", ExactSpelling = true)]
        public static extern bool8 ShowWindowSystemMenu(SDL_Window* window, int x, int y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowHitTest", ExactSpelling = true)]
        public static extern bool8 SetWindowHitTest(SDL_Window* window,delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> callback, void* callback_data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowShape", ExactSpelling = true)]
        public static extern bool8 SetWindowShape(SDL_Window* window, SDL_Surface* shape);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlashWindow", ExactSpelling = true)]
        public static extern bool8 FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
        public static extern void DestroyWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScreenSaverEnabled", ExactSpelling = true)]
        public static extern bool8 ScreenSaverEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnableScreenSaver", ExactSpelling = true)]
        public static extern bool8 EnableScreenSaver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DisableScreenSaver", ExactSpelling = true)]
        public static extern bool8 DisableScreenSaver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_LoadLibrary", ExactSpelling = true)]
        public static extern bool8 GL_LoadLibrary(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
        public static extern delegate* unmanaged[Cdecl]<void> GL_GetProcAddress(byte* proc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetProcAddress", ExactSpelling = true)]
        public static extern delegate* unmanaged[Cdecl]<void> EGL_GetProcAddress(byte* proc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_UnloadLibrary", ExactSpelling = true)]
        public static extern void GL_UnloadLibrary();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ExtensionSupported", ExactSpelling = true)]
        public static extern bool8 GL_ExtensionSupported(byte* extension);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ResetAttributes", ExactSpelling = true)]
        public static extern void GL_ResetAttributes();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetAttribute", ExactSpelling = true)]
        public static extern bool8 GL_SetAttribute(SDL_GLAttr attr, int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetAttribute", ExactSpelling = true)]
        public static extern bool8 GL_GetAttribute(SDL_GLAttr attr, int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
        public static extern SDL_GLContextState* GL_CreateContext(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
        public static extern bool8 GL_MakeCurrent(SDL_Window* window,SDL_GLContextState* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentWindow", ExactSpelling = true)]
        public static extern SDL_Window* GL_GetCurrentWindow();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
        public static extern SDL_GLContextState* GL_GetCurrentContext();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetCurrentDisplay", ExactSpelling = true)]
        public static extern void* EGL_GetCurrentDisplay();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetCurrentConfig", ExactSpelling = true)]
        public static extern void* EGL_GetCurrentConfig();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetWindowSurface", ExactSpelling = true)]
        public static extern void* EGL_GetWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_SetAttributeCallbacks", ExactSpelling = true)]
        public static extern void EGL_SetAttributeCallbacks(delegate* unmanaged[Cdecl]<void*, nint*> platformAttribCallback,delegate* unmanaged[Cdecl]<void*, void*, void*, int*> surfaceAttribCallback,delegate* unmanaged[Cdecl]<void*, void*, void*, int*> contextAttribCallback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetSwapInterval", ExactSpelling = true)]
        public static extern bool8 GL_SetSwapInterval(int interval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetSwapInterval", ExactSpelling = true)]
        public static extern bool8 GL_GetSwapInterval(int* interval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
        public static extern bool8 GL_SwapWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_DestroyContext", ExactSpelling = true)]
        public static extern bool8 GL_DestroyContext(SDL_GLContextState* context);
    }
}
