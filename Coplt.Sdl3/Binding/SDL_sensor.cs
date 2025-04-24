using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Sensor
    {
    }

    public enum SDL_SensorType
    {
        SDL_SENSOR_INVALID = -1,
        SDL_SENSOR_UNKNOWN,
        SDL_SENSOR_ACCEL,
        SDL_SENSOR_GYRO,
        SDL_SENSOR_ACCEL_L,
        SDL_SENSOR_GYRO_L,
        SDL_SENSOR_ACCEL_R,
        SDL_SENSOR_GYRO_R,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensors", ExactSpelling = true)]
        public static extern SDL_SensorID* GetSensors(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNameForID", ExactSpelling = true)]
        public static extern byte* GetSensorNameForID(SDL_SensorID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorTypeForID", ExactSpelling = true)]
        public static extern SDL_SensorType GetSensorTypeForID(SDL_SensorID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNonPortableTypeForID", ExactSpelling = true)]
        public static extern int GetSensorNonPortableTypeForID(SDL_SensorID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenSensor", ExactSpelling = true)]
        public static extern SDL_Sensor* OpenSensor(SDL_SensorID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorFromID", ExactSpelling = true)]
        public static extern SDL_Sensor* GetSensorFromID(SDL_SensorID instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorProperties", ExactSpelling = true)]
        public static extern SDL_PropertiesID GetSensorProperties(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorName", ExactSpelling = true)]
        public static extern byte* GetSensorName(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorType", ExactSpelling = true)]
        public static extern SDL_SensorType GetSensorType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNonPortableType", ExactSpelling = true)]
        public static extern int GetSensorNonPortableType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorID", ExactSpelling = true)]
        public static extern SDL_SensorID GetSensorID(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorData", ExactSpelling = true)]
        public static extern bool8 GetSensorData(SDL_Sensor* sensor, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseSensor", ExactSpelling = true)]
        public static extern void CloseSensor(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateSensors", ExactSpelling = true)]
        public static extern void UpdateSensors();
    }
}
