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
        public static extern byte* GetCameraDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentCameraDriver", ExactSpelling = true)]
        public static extern byte* GetCurrentCameraDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameras", ExactSpelling = true)]
        public static extern SDL_CameraID* GetCameras(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraSupportedFormats", ExactSpelling = true)]
        public static extern SDL_CameraSpec** GetCameraSupportedFormats(SDL_CameraID instance_id, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraName", ExactSpelling = true)]
        public static extern byte* GetCameraName(SDL_CameraID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraPosition", ExactSpelling = true)]
        public static extern SDL_CameraPosition GetCameraPosition(SDL_CameraID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenCamera", ExactSpelling = true)]
        public static extern SDL_Camera* OpenCamera(SDL_CameraID instance_id,SDL_CameraSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraPermissionState", ExactSpelling = true)]
        public static extern int GetCameraPermissionState(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraID", ExactSpelling = true)]
        public static extern SDL_CameraID GetCameraID(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraProperties", ExactSpelling = true)]
        public static extern SDL_PropertiesID GetCameraProperties(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraFormat", ExactSpelling = true)]
        public static extern bool8 GetCameraFormat(SDL_Camera* camera, SDL_CameraSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireCameraFrame", ExactSpelling = true)]
        public static extern SDL_Surface* AcquireCameraFrame(SDL_Camera* camera,ulong* timestampNS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseCameraFrame", ExactSpelling = true)]
        public static extern void ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseCamera", ExactSpelling = true)]
        public static extern void CloseCamera(SDL_Camera* camera);
    }
}
