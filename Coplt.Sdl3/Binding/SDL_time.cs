using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_DateTime
    {
        public int year;

        public int month;

        public int day;

        public int hour;

        public int minute;

        public int second;

        public int nanosecond;

        public int day_of_week;

        public int utc_offset;
    }

    public enum SDL_DateFormat
    {
        Yyyymmdd = 0,
        Ddmmyyyy = 1,
        Mmddyyyy = 2,
    }

    public enum SDL_TimeFormat
    {
        _24hr = 0,
        _12hr = 1,
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDateTimeLocalePreferences", ExactSpelling = true)]
        public static extern bool8 GetDateTimeLocalePreferences(SDL_DateFormat* dateFormat, SDL_TimeFormat* timeFormat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentTime", ExactSpelling = true)]
        public static extern bool8 GetCurrentTime(long* ticks);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeToDateTime", ExactSpelling = true)]
        public static extern bool8 TimeToDateTime(long ticks, SDL_DateTime* dt,bool8 localTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DateTimeToTime", ExactSpelling = true)]
        public static extern bool8 DateTimeToTime(SDL_DateTime* dt,long* ticks);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeToWindows", ExactSpelling = true)]
        public static extern void TimeToWindows(long ticks,uint* dwLowDateTime,uint* dwHighDateTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeFromWindows", ExactSpelling = true)]
        public static extern long TimeFromWindows(uint dwLowDateTime,uint dwHighDateTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDaysInMonth", ExactSpelling = true)]
        public static extern int GetDaysInMonth(int year, int month);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDayOfYear", ExactSpelling = true)]
        public static extern int GetDayOfYear(int year, int month, int day);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDayOfWeek", ExactSpelling = true)]
        public static extern int GetDayOfWeek(int year, int month, int day);
    }
}
