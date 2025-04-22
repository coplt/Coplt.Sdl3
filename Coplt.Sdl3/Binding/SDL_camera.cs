using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Camera
    {
    }

    public partial struct SDL_CameraSpec
    {
        public SDL_PixelFormat format;

        public SDL_Colorspace colorspace;

        public int width;

        public int height;

        public int framerate_numerator;

        public int framerate_denominator;
    }

    public enum SDL_CameraPosition
    {
        SDL_CAMERA_POSITION_UNKNOWN,
        SDL_CAMERA_POSITION_FRONT_FACING,
        SDL_CAMERA_POSITION_BACK_FACING,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumCameraDrivers", ExactSpelling = true)]
        public static extern int GetNumCameraDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetCameraDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentCameraDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetCurrentCameraDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameras", ExactSpelling = true)]
        [return: NativeTypeName("SDL_CameraID *")]
        public static extern uint* GetCameras(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraSupportedFormats", ExactSpelling = true)]
        public static extern SDL_CameraSpec** GetCameraSupportedFormats([NativeTypeName("SDL_CameraID")] uint instance_id, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetCameraName([NativeTypeName("SDL_CameraID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraPosition", ExactSpelling = true)]
        public static extern SDL_CameraPosition GetCameraPosition([NativeTypeName("SDL_CameraID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenCamera", ExactSpelling = true)]
        public static extern SDL_Camera* OpenCamera([NativeTypeName("SDL_CameraID")] uint instance_id, [NativeTypeName("const SDL_CameraSpec *")] SDL_CameraSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraPermissionState", ExactSpelling = true)]
        public static extern int GetCameraPermissionState(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraID", ExactSpelling = true)]
        [return: NativeTypeName("SDL_CameraID")]
        public static extern uint GetCameraID(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetCameraProperties(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraFormat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetCameraFormat(SDL_Camera* camera, SDL_CameraSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireCameraFrame", ExactSpelling = true)]
        public static extern SDL_Surface* AcquireCameraFrame(SDL_Camera* camera, [NativeTypeName("Uint64 *")] ulong* timestampNS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseCameraFrame", ExactSpelling = true)]
        public static extern void ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseCamera", ExactSpelling = true)]
        public static extern void CloseCamera(SDL_Camera* camera);
    }
}
