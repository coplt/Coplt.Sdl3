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
        public static extern SDL_PropertiesID GetGlobalProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProperties", ExactSpelling = true)]
        public static extern SDL_PropertiesID CreateProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyProperties", ExactSpelling = true)]
        public static extern bool8 CopyProperties(SDL_PropertiesID src, SDL_PropertiesID dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockProperties", ExactSpelling = true)]
        public static extern bool8 LockProperties(SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockProperties", ExactSpelling = true)]
        public static extern void UnlockProperties(SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerPropertyWithCleanup", ExactSpelling = true)]
        public static extern bool8 SetPointerPropertyWithCleanup(SDL_PropertiesID props,byte* name, void* value,delegate* unmanaged[Cdecl]<void*, void*, void> cleanup, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerProperty", ExactSpelling = true)]
        public static extern bool8 SetPointerProperty(SDL_PropertiesID props,byte* name, void* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetStringProperty", ExactSpelling = true)]
        public static extern bool8 SetStringProperty(SDL_PropertiesID props,byte* name,byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetNumberProperty", ExactSpelling = true)]
        public static extern bool8 SetNumberProperty(SDL_PropertiesID props,byte* name,long value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetFloatProperty", ExactSpelling = true)]
        public static extern bool8 SetFloatProperty(SDL_PropertiesID props,byte* name, float value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetBooleanProperty", ExactSpelling = true)]
        public static extern bool8 SetBooleanProperty(SDL_PropertiesID props,byte* name,bool8 value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasProperty", ExactSpelling = true)]
        public static extern bool8 HasProperty(SDL_PropertiesID props,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPropertyType", ExactSpelling = true)]
        public static extern SDL_PropertyType GetPropertyType(SDL_PropertiesID props,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPointerProperty", ExactSpelling = true)]
        public static extern void* GetPointerProperty(SDL_PropertiesID props,byte* name, void* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStringProperty", ExactSpelling = true)]
        public static extern byte* GetStringProperty(SDL_PropertiesID props,byte* name,byte* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumberProperty", ExactSpelling = true)]
        public static extern long GetNumberProperty(SDL_PropertiesID props,byte* name,long default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFloatProperty", ExactSpelling = true)]
        public static extern float GetFloatProperty(SDL_PropertiesID props,byte* name, float default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBooleanProperty", ExactSpelling = true)]
        public static extern bool8 GetBooleanProperty(SDL_PropertiesID props,byte* name,bool8 default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearProperty", ExactSpelling = true)]
        public static extern bool8 ClearProperty(SDL_PropertiesID props,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateProperties", ExactSpelling = true)]
        public static extern bool8 EnumerateProperties(SDL_PropertiesID props,delegate* unmanaged[Cdecl]<void*, SDL_PropertiesID, byte*, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProperties", ExactSpelling = true)]
        public static extern void DestroyProperties(SDL_PropertiesID props);
    }
}
