using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_AudioFormat : uint
    {
        SDL_AUDIO_UNKNOWN = 0x0000U,
        SDL_AUDIO_U8 = 0x0008U,
        SDL_AUDIO_S8 = 0x8008U,
        SDL_AUDIO_S16LE = 0x8010U,
        SDL_AUDIO_S16BE = 0x9010U,
        SDL_AUDIO_S32LE = 0x8020U,
        SDL_AUDIO_S32BE = 0x9020U,
        SDL_AUDIO_F32LE = 0x8120U,
        SDL_AUDIO_F32BE = 0x9120U,
        SDL_AUDIO_S16 = SDL_AUDIO_S16LE,
        SDL_AUDIO_S32 = SDL_AUDIO_S32LE,
        SDL_AUDIO_F32 = SDL_AUDIO_F32LE,
    }

    public partial struct SDL_AudioSpec
    {
        public SDL_AudioFormat format;

        public int channels;

        public int freq;
    }

    public partial struct SDL_AudioStream
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAudioDrivers", ExactSpelling = true)]
        public static extern int GetNumAudioDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetAudioDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentAudioDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetCurrentAudioDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioPlaybackDevices", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID *")]
        public static extern uint* GetAudioPlaybackDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioRecordingDevices", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID *")]
        public static extern uint* GetAudioRecordingDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetAudioDeviceName([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceFormat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetAudioDeviceFormat([NativeTypeName("SDL_AudioDeviceID")] uint devid, SDL_AudioSpec* spec, int* sample_frames);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceChannelMap", ExactSpelling = true)]
        public static extern int* GetAudioDeviceChannelMap([NativeTypeName("SDL_AudioDeviceID")] uint devid, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenAudioDevice", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID")]
        public static extern uint OpenAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsAudioDevicePhysical", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 IsAudioDevicePhysical([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsAudioDevicePlayback", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 IsAudioDevicePlayback([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseAudioDevice", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeAudioDevice", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ResumeAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioDevicePaused", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 AudioDevicePaused([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceGain", ExactSpelling = true)]
        public static extern float GetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioDeviceGain", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid, float gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseAudioDevice", ExactSpelling = true)]
        public static extern void CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindAudioStreams", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BindAudioStreams([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("SDL_AudioStream *const *")] SDL_AudioStream** streams, int num_streams);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 BindAudioStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnbindAudioStreams", ExactSpelling = true)]
        public static extern void UnbindAudioStreams([NativeTypeName("SDL_AudioStream *const *")] SDL_AudioStream** streams, int num_streams);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnbindAudioStream", ExactSpelling = true)]
        public static extern void UnbindAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamDevice", ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID")]
        public static extern uint GetAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateAudioStream", ExactSpelling = true)]
        public static extern SDL_AudioStream* CreateAudioStream([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetAudioStreamProperties(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamFormat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamFormat", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioStreamFormat(SDL_AudioStream* stream, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamFrequencyRatio", ExactSpelling = true)]
        public static extern float GetAudioStreamFrequencyRatio(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamFrequencyRatio", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamGain", ExactSpelling = true)]
        public static extern float GetAudioStreamGain(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamGain", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioStreamGain(SDL_AudioStream* stream, float gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamInputChannelMap", ExactSpelling = true)]
        public static extern int* GetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamOutputChannelMap", ExactSpelling = true)]
        public static extern int* GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamInputChannelMap", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioStreamInputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamOutputChannelMap", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PutAudioStreamData", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 PutAudioStreamData(SDL_AudioStream* stream, [NativeTypeName("const void *")] void* buf, int len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamData", ExactSpelling = true)]
        public static extern int GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamAvailable", ExactSpelling = true)]
        public static extern int GetAudioStreamAvailable(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamQueued", ExactSpelling = true)]
        public static extern int GetAudioStreamQueued(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 FlushAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ClearAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseAudioStreamDevice", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 PauseAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeAudioStreamDevice", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ResumeAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioStreamDevicePaused", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 AudioStreamDevicePaused(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 LockAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockAudioStream", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 UnlockAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamGetCallback", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioStreamGetCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamPutCallback", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioStreamPutCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyAudioStream", ExactSpelling = true)]
        public static extern void DestroyAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenAudioDeviceStream", ExactSpelling = true)]
        public static extern SDL_AudioStream* OpenAudioDeviceStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioPostmixCallback", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetAudioPostmixCallback([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("SDL_AudioPostmixCallback")] delegate* unmanaged[Cdecl]<void*, SDL_AudioSpec*, float*, int, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadWAV_IO", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 LoadWAV_IO(SDL_IOStream* src, [NativeTypeName("_Bool")] bool8 closeio, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadWAV", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 LoadWAV([NativeTypeName("const char *")] byte* path, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MixAudio", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 MixAudio([NativeTypeName("Uint8 *")] byte* dst, [NativeTypeName("const Uint8 *")] byte* src, SDL_AudioFormat format, [NativeTypeName("Uint32")] uint len, float volume);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertAudioSamples", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ConvertAudioSamples([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const Uint8 *")] byte* src_data, int src_len, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec, [NativeTypeName("Uint8 **")] byte** dst_data, int* dst_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioFormatName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetAudioFormatName(SDL_AudioFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSilenceValueForFormat", ExactSpelling = true)]
        public static extern int GetSilenceValueForFormat(SDL_AudioFormat format);
    }
}
