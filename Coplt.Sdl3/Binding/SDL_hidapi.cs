using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_hid_device
    {
    }

    public enum SDL_hid_bus_type
    {
        SDL_HID_API_BUS_UNKNOWN = 0x00,
        SDL_HID_API_BUS_USB = 0x01,
        SDL_HID_API_BUS_BLUETOOTH = 0x02,
        SDL_HID_API_BUS_I2C = 0x03,
        SDL_HID_API_BUS_SPI = 0x04,
    }

    public unsafe partial struct SDL_hid_device_info
    {
        public byte* path;
        public ushort vendor_id;
        public ushort product_id;
        public ushort* serial_number;
        public ushort release_number;
        public ushort* manufacturer_string;
        public ushort* product_string;
        public ushort usage_page;
        public ushort usage;

        public int interface_number;

        public int interface_class;

        public int interface_subclass;

        public int interface_protocol;

        public SDL_hid_bus_type bus_type;
        public SDL_hid_device_info* next;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_init", ExactSpelling = true)]
        public static extern int hid_init();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_exit", ExactSpelling = true)]
        public static extern int hid_exit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_device_change_count", ExactSpelling = true)]
        public static extern uint hid_device_change_count();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_enumerate", ExactSpelling = true)]
        public static extern SDL_hid_device_info* hid_enumerate(ushort vendor_id,ushort product_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_free_enumeration", ExactSpelling = true)]
        public static extern void hid_free_enumeration(SDL_hid_device_info* devs);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_open", ExactSpelling = true)]
        public static extern SDL_hid_device* hid_open(ushort vendor_id,ushort product_id,ushort* serial_number);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_open_path", ExactSpelling = true)]
        public static extern SDL_hid_device* hid_open_path(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_write", ExactSpelling = true)]
        public static extern int hid_write(SDL_hid_device* dev,byte* data,nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_read_timeout", ExactSpelling = true)]
        public static extern int hid_read_timeout(SDL_hid_device* dev,byte* data,nuint length, int milliseconds);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_read", ExactSpelling = true)]
        public static extern int hid_read(SDL_hid_device* dev,byte* data,nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_set_nonblocking", ExactSpelling = true)]
        public static extern int hid_set_nonblocking(SDL_hid_device* dev, int nonblock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_send_feature_report", ExactSpelling = true)]
        public static extern int hid_send_feature_report(SDL_hid_device* dev,byte* data,nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_feature_report", ExactSpelling = true)]
        public static extern int hid_get_feature_report(SDL_hid_device* dev,byte* data,nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_input_report", ExactSpelling = true)]
        public static extern int hid_get_input_report(SDL_hid_device* dev,byte* data,nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_close", ExactSpelling = true)]
        public static extern int hid_close(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_manufacturer_string", ExactSpelling = true)]
        public static extern int hid_get_manufacturer_string(SDL_hid_device* dev,ushort* @string,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_product_string", ExactSpelling = true)]
        public static extern int hid_get_product_string(SDL_hid_device* dev,ushort* @string,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_serial_number_string", ExactSpelling = true)]
        public static extern int hid_get_serial_number_string(SDL_hid_device* dev,ushort* @string,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_indexed_string", ExactSpelling = true)]
        public static extern int hid_get_indexed_string(SDL_hid_device* dev, int string_index,ushort* @string,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_device_info", ExactSpelling = true)]
        public static extern SDL_hid_device_info* hid_get_device_info(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_report_descriptor", ExactSpelling = true)]
        public static extern int hid_get_report_descriptor(SDL_hid_device* dev,byte* buf,nuint buf_size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_ble_scan", ExactSpelling = true)]
        public static extern void hid_ble_scan(bool8 active);
    }
}
