using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public enum SDL_PropertyType
    {
        SDL_PROPERTY_TYPE_INVALID,
        SDL_PROPERTY_TYPE_POINTER,
        SDL_PROPERTY_TYPE_STRING,
        SDL_PROPERTY_TYPE_NUMBER,
        SDL_PROPERTY_TYPE_FLOAT,
        SDL_PROPERTY_TYPE_BOOLEAN,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGlobalProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint GetGlobalProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProperties", ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint CreateProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyProperties", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 CopyProperties([NativeTypeName("SDL_PropertiesID")] uint src, [NativeTypeName("SDL_PropertiesID")] uint dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockProperties", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 LockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockProperties", ExactSpelling = true)]
        public static extern void UnlockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerPropertyWithCleanup", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetPointerPropertyWithCleanup([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, void* value, [NativeTypeName("SDL_CleanupPropertyCallback")] delegate* unmanaged[Cdecl]<void*, void*, void> cleanup, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetPointerProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, void* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetStringProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetStringProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetNumberProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetNumberProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("Sint64")] long value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetFloatProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetFloatProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, float value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetBooleanProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetBooleanProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("_Bool")] bool8 value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 HasProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPropertyType", ExactSpelling = true)]
        public static extern SDL_PropertyType GetPropertyType([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPointerProperty", ExactSpelling = true)]
        public static extern void* GetPointerProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, void* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStringProperty", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetStringProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumberProperty", ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern long GetNumberProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("Sint64")] long default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFloatProperty", ExactSpelling = true)]
        public static extern float GetFloatProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, float default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBooleanProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetBooleanProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("_Bool")] bool8 default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearProperty", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 ClearProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateProperties", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 EnumerateProperties([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("SDL_EnumeratePropertiesCallback")] delegate* unmanaged[Cdecl]<void*, uint, byte*, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProperties", ExactSpelling = true)]
        public static extern void DestroyProperties([NativeTypeName("SDL_PropertiesID")] uint props);
    }
}
