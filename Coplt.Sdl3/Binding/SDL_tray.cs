using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_Tray
    {
    }

    public partial struct SDL_TrayMenu
    {
    }

    public partial struct SDL_TrayEntry
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTray", ExactSpelling = true)]
        public static extern SDL_Tray* CreateTray(SDL_Surface* icon, [NativeTypeName("const char *")] byte* tooltip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayIcon", ExactSpelling = true)]
        public static extern void SetTrayIcon(SDL_Tray* tray, SDL_Surface* icon);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayTooltip", ExactSpelling = true)]
        public static extern void SetTrayTooltip(SDL_Tray* tray, [NativeTypeName("const char *")] byte* tooltip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTrayMenu", ExactSpelling = true)]
        public static extern SDL_TrayMenu* CreateTrayMenu(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTraySubmenu", ExactSpelling = true)]
        public static extern SDL_TrayMenu* CreateTraySubmenu(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayMenu", ExactSpelling = true)]
        public static extern SDL_TrayMenu* GetTrayMenu(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTraySubmenu", ExactSpelling = true)]
        public static extern SDL_TrayMenu* GetTraySubmenu(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntries", ExactSpelling = true)]
        [return: NativeTypeName("const SDL_TrayEntry **")]
        public static extern SDL_TrayEntry** GetTrayEntries(SDL_TrayMenu* menu, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveTrayEntry", ExactSpelling = true)]
        public static extern void RemoveTrayEntry(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InsertTrayEntryAt", ExactSpelling = true)]
        public static extern SDL_TrayEntry* InsertTrayEntryAt(SDL_TrayMenu* menu, int pos, [NativeTypeName("const char *")] byte* label, [NativeTypeName("SDL_TrayEntryFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryLabel", ExactSpelling = true)]
        public static extern void SetTrayEntryLabel(SDL_TrayEntry* entry, [NativeTypeName("const char *")] byte* label);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryLabel", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetTrayEntryLabel(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryChecked", ExactSpelling = true)]
        public static extern void SetTrayEntryChecked(SDL_TrayEntry* entry, [NativeTypeName("_Bool")] bool8 @checked);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryChecked", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTrayEntryChecked(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryEnabled", ExactSpelling = true)]
        public static extern void SetTrayEntryEnabled(SDL_TrayEntry* entry, [NativeTypeName("_Bool")] bool8 enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryEnabled", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 GetTrayEntryEnabled(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryCallback", ExactSpelling = true)]
        public static extern void SetTrayEntryCallback(SDL_TrayEntry* entry, [NativeTypeName("SDL_TrayCallback")] delegate* unmanaged[Cdecl]<void*, SDL_TrayEntry*, void> callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClickTrayEntry", ExactSpelling = true)]
        public static extern void ClickTrayEntry(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyTray", ExactSpelling = true)]
        public static extern void DestroyTray(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryParent", ExactSpelling = true)]
        public static extern SDL_TrayMenu* GetTrayEntryParent(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayMenuParentEntry", ExactSpelling = true)]
        public static extern SDL_TrayEntry* GetTrayMenuParentEntry(SDL_TrayMenu* menu);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayMenuParentTray", ExactSpelling = true)]
        public static extern SDL_Tray* GetTrayMenuParentTray(SDL_TrayMenu* menu);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateTrays", ExactSpelling = true)]
        public static extern void UpdateTrays();
    }
}
