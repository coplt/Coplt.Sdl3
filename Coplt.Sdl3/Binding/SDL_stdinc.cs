using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_alignment_test
    {
        public byte a;

        public void* b;
    }

    public enum SDL_DUMMY_ENUM
    {
        DUMMY_ENUM_VALUE,
    }

    public partial struct SDL_Environment
    {
    }

    public partial struct SDL_iconv_data_t
    {
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_malloc", ExactSpelling = true)]
        public static extern void* malloc(nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_calloc", ExactSpelling = true)]
        public static extern void* calloc(nuint nmemb,nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_realloc", ExactSpelling = true)]
        public static extern void* realloc(void* mem,nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_free", ExactSpelling = true)]
        public static extern void free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetOriginalMemoryFunctions", ExactSpelling = true)]
        public static extern void GetOriginalMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*>* malloc_func,delegate* unmanaged[Cdecl]<nuint, nuint, void*>* calloc_func,delegate* unmanaged[Cdecl]<void*, nuint, void*>* realloc_func,delegate* unmanaged[Cdecl]<void*, void>* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMemoryFunctions", ExactSpelling = true)]
        public static extern void GetMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*>* malloc_func,delegate* unmanaged[Cdecl]<nuint, nuint, void*>* calloc_func,delegate* unmanaged[Cdecl]<void*, nuint, void*>* realloc_func,delegate* unmanaged[Cdecl]<void*, void>* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetMemoryFunctions", ExactSpelling = true)]
        public static extern bool8 SetMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*> malloc_func,delegate* unmanaged[Cdecl]<nuint, nuint, void*> calloc_func,delegate* unmanaged[Cdecl]<void*, nuint, void*> realloc_func,delegate* unmanaged[Cdecl]<void*, void> free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_alloc", ExactSpelling = true)]
        public static extern void* aligned_alloc(nuint alignment,nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_free", ExactSpelling = true)]
        public static extern void aligned_free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAllocations", ExactSpelling = true)]
        public static extern int GetNumAllocations();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironment", ExactSpelling = true)]
        public static extern SDL_Environment* GetEnvironment();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateEnvironment", ExactSpelling = true)]
        public static extern SDL_Environment* CreateEnvironment(bool8 populated);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariable", ExactSpelling = true)]
        public static extern byte* GetEnvironmentVariable(SDL_Environment* env,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariables", ExactSpelling = true)]
        public static extern byte** GetEnvironmentVariables(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEnvironmentVariable", ExactSpelling = true)]
        public static extern bool8 SetEnvironmentVariable(SDL_Environment* env,byte* name,byte* value,bool8 overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnsetEnvironmentVariable", ExactSpelling = true)]
        public static extern bool8 UnsetEnvironmentVariable(SDL_Environment* env,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyEnvironment", ExactSpelling = true)]
        public static extern void DestroyEnvironment(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv", ExactSpelling = true)]
        public static extern byte* getenv(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv_unsafe", ExactSpelling = true)]
        public static extern byte* getenv_unsafe(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_setenv_unsafe", ExactSpelling = true)]
        public static extern int setenv_unsafe(byte* name,byte* value, int overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_unsetenv_unsafe", ExactSpelling = true)]
        public static extern int unsetenv_unsafe(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort", ExactSpelling = true)]
        public static extern void qsort(void* @base,nuint nmemb,nuint size,delegate* unmanaged[Cdecl]<void*, void*, int> compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch", ExactSpelling = true)]
        public static extern void* bsearch(void* key,void* @base,nuint nmemb,nuint size,delegate* unmanaged[Cdecl]<void*, void*, int> compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort_r", ExactSpelling = true)]
        public static extern void qsort_r(void* @base,nuint nmemb,nuint size,delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch_r", ExactSpelling = true)]
        public static extern void* bsearch_r(void* key,void* @base,nuint nmemb,nuint size,delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_abs", ExactSpelling = true)]
        public static extern int abs(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isalpha", ExactSpelling = true)]
        public static extern int isalpha(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isalnum", ExactSpelling = true)]
        public static extern int isalnum(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isblank", ExactSpelling = true)]
        public static extern int isblank(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iscntrl", ExactSpelling = true)]
        public static extern int iscntrl(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isdigit", ExactSpelling = true)]
        public static extern int isdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isxdigit", ExactSpelling = true)]
        public static extern int isxdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ispunct", ExactSpelling = true)]
        public static extern int ispunct(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isspace", ExactSpelling = true)]
        public static extern int isspace(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isupper", ExactSpelling = true)]
        public static extern int isupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_islower", ExactSpelling = true)]
        public static extern int islower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isprint", ExactSpelling = true)]
        public static extern int isprint(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isgraph", ExactSpelling = true)]
        public static extern int isgraph(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_toupper", ExactSpelling = true)]
        public static extern int toupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tolower", ExactSpelling = true)]
        public static extern int tolower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc16", ExactSpelling = true)]
        public static extern ushort crc16(ushort crc,void* data,nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc32", ExactSpelling = true)]
        public static extern uint crc32(uint crc,void* data,nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_murmur3_32", ExactSpelling = true)]
        public static extern uint murmur3_32(void* data,nuint len,uint seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcpy", ExactSpelling = true)]
        public static extern void* memcpy(void* dst,void* src,nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memmove", ExactSpelling = true)]
        public static extern void* memmove(void* dst,void* src,nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memset", ExactSpelling = true)]
        public static extern void* memset(void* dst, int c,nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memset4", ExactSpelling = true)]
        public static extern void* memset4(void* dst,uint val,nuint dwords);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcmp", ExactSpelling = true)]
        public static extern int memcmp(void* s1,void* s2,nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslen", ExactSpelling = true)]
        public static extern nuint wcslen(ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsnlen", ExactSpelling = true)]
        public static extern nuint wcsnlen(ushort* wstr,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcpy", ExactSpelling = true)]
        public static extern nuint wcslcpy(ushort* dst,ushort* src,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcat", ExactSpelling = true)]
        public static extern nuint wcslcat(ushort* dst,ushort* src,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsdup", ExactSpelling = true)]
        public static extern ushort* wcsdup(ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsstr", ExactSpelling = true)]
        public static extern ushort* wcsstr(ushort* haystack,ushort* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsnstr", ExactSpelling = true)]
        public static extern ushort* wcsnstr(ushort* haystack,ushort* needle,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscmp", ExactSpelling = true)]
        public static extern int wcscmp(ushort* str1,ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncmp", ExactSpelling = true)]
        public static extern int wcsncmp(ushort* str1,ushort* str2,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscasecmp", ExactSpelling = true)]
        public static extern int wcscasecmp(ushort* str1,ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncasecmp", ExactSpelling = true)]
        public static extern int wcsncasecmp(ushort* str1,ushort* str2,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstol", ExactSpelling = true)]
        public static extern nint wcstol(ushort* str,ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlen", ExactSpelling = true)]
        public static extern nuint strlen(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strnlen", ExactSpelling = true)]
        public static extern nuint strnlen(byte* str,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcpy", ExactSpelling = true)]
        public static extern nuint strlcpy(byte* dst,byte* src,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlcpy", ExactSpelling = true)]
        public static extern nuint utf8strlcpy(byte* dst,byte* src,nuint dst_bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcat", ExactSpelling = true)]
        public static extern nuint strlcat(byte* dst,byte* src,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strdup", ExactSpelling = true)]
        public static extern byte* strdup(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strndup", ExactSpelling = true)]
        public static extern byte* strndup(byte* str,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrev", ExactSpelling = true)]
        public static extern byte* strrev(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strupr", ExactSpelling = true)]
        public static extern byte* strupr(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlwr", ExactSpelling = true)]
        public static extern byte* strlwr(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strchr", ExactSpelling = true)]
        public static extern byte* strchr(byte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrchr", ExactSpelling = true)]
        public static extern byte* strrchr(byte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strstr", ExactSpelling = true)]
        public static extern byte* strstr(byte* haystack,byte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strnstr", ExactSpelling = true)]
        public static extern byte* strnstr(byte* haystack,byte* needle,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasestr", ExactSpelling = true)]
        public static extern byte* strcasestr(byte* haystack,byte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtok_r", ExactSpelling = true)]
        public static extern byte* strtok_r(byte* str,byte* delim,byte** saveptr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlen", ExactSpelling = true)]
        public static extern nuint utf8strlen(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strnlen", ExactSpelling = true)]
        public static extern nuint utf8strnlen(byte* str,nuint bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_itoa", ExactSpelling = true)]
        public static extern byte* itoa(int value,byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_uitoa", ExactSpelling = true)]
        public static extern byte* uitoa(uint value,byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ltoa", ExactSpelling = true)]
        public static extern byte* ltoa(nint value,byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ultoa", ExactSpelling = true)]
        public static extern byte* ultoa(nuint value,byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lltoa", ExactSpelling = true)]
        public static extern byte* lltoa(long value,byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ulltoa", ExactSpelling = true)]
        public static extern byte* ulltoa(ulong value,byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atoi", ExactSpelling = true)]
        public static extern int atoi(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atof", ExactSpelling = true)]
        public static extern double atof(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtol", ExactSpelling = true)]
        public static extern nint strtol(byte* str,byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoul", ExactSpelling = true)]
        public static extern nuint strtoul(byte* str,byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoll", ExactSpelling = true)]
        public static extern long strtoll(byte* str,byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoull", ExactSpelling = true)]
        public static extern ulong strtoull(byte* str,byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtod", ExactSpelling = true)]
        public static extern double strtod(byte* str,byte** endp);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcmp", ExactSpelling = true)]
        public static extern int strcmp(byte* str1,byte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncmp", ExactSpelling = true)]
        public static extern int strncmp(byte* str1,byte* str2,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasecmp", ExactSpelling = true)]
        public static extern int strcasecmp(byte* str1,byte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncasecmp", ExactSpelling = true)]
        public static extern int strncasecmp(byte* str1,byte* str2,nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strpbrk", ExactSpelling = true)]
        public static extern byte* strpbrk(byte* str,byte* breakset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StepUTF8", ExactSpelling = true)]
        public static extern uint StepUTF8(byte** pstr,nuint* pslen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StepBackUTF8", ExactSpelling = true)]
        public static extern uint StepBackUTF8(byte* start,byte** pstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UCS4ToUTF8", ExactSpelling = true)]
        public static extern byte* UCS4ToUTF8(uint codepoint,byte* dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sscanf", ExactSpelling = true)]
        public static extern int sscanf(byte* text,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vsscanf", ExactSpelling = true)]
        public static extern int vsscanf(byte* text,byte* fmt,byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_snprintf", ExactSpelling = true)]
        public static extern int snprintf(byte* text,nuint maxlen,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_swprintf", ExactSpelling = true)]
        public static extern int swprintf(ushort* text,nuint maxlen,ushort* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vsnprintf", ExactSpelling = true)]
        public static extern int vsnprintf(byte* text,nuint maxlen,byte* fmt,byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vswprintf", ExactSpelling = true)]
        public static extern int vswprintf(ushort* text,nuint maxlen,ushort* fmt,byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asprintf", ExactSpelling = true)]
        public static extern int asprintf(byte** strp,byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vasprintf", ExactSpelling = true)]
        public static extern int vasprintf(byte** strp,byte* fmt,byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_srand", ExactSpelling = true)]
        public static extern void srand(ulong seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand", ExactSpelling = true)]
        public static extern int rand(int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_randf", ExactSpelling = true)]
        public static extern float randf();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_bits", ExactSpelling = true)]
        public static extern uint rand_bits();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_r", ExactSpelling = true)]
        public static extern int rand_r(ulong* state,int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_randf_r", ExactSpelling = true)]
        public static extern float randf_r(ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_bits_r", ExactSpelling = true)]
        public static extern uint rand_bits_r(ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_acos", ExactSpelling = true)]
        public static extern double acos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_acosf", ExactSpelling = true)]
        public static extern float acosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asin", ExactSpelling = true)]
        public static extern double asin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asinf", ExactSpelling = true)]
        public static extern float asinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan", ExactSpelling = true)]
        public static extern double atan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atanf", ExactSpelling = true)]
        public static extern float atanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan2", ExactSpelling = true)]
        public static extern double atan2(double y, double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan2f", ExactSpelling = true)]
        public static extern float atan2f(float y, float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ceil", ExactSpelling = true)]
        public static extern double ceil(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ceilf", ExactSpelling = true)]
        public static extern float ceilf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_copysign", ExactSpelling = true)]
        public static extern double copysign(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_copysignf", ExactSpelling = true)]
        public static extern float copysignf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_cos", ExactSpelling = true)]
        public static extern double cos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_cosf", ExactSpelling = true)]
        public static extern float cosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_exp", ExactSpelling = true)]
        public static extern double exp(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_expf", ExactSpelling = true)]
        public static extern float expf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fabs", ExactSpelling = true)]
        public static extern double fabs(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fabsf", ExactSpelling = true)]
        public static extern float fabsf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_floor", ExactSpelling = true)]
        public static extern double floor(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_floorf", ExactSpelling = true)]
        public static extern float floorf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_trunc", ExactSpelling = true)]
        public static extern double trunc(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_truncf", ExactSpelling = true)]
        public static extern float truncf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fmod", ExactSpelling = true)]
        public static extern double fmod(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fmodf", ExactSpelling = true)]
        public static extern float fmodf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isinf", ExactSpelling = true)]
        public static extern int isinf(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isinff", ExactSpelling = true)]
        public static extern int isinff(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isnan", ExactSpelling = true)]
        public static extern int isnan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isnanf", ExactSpelling = true)]
        public static extern int isnanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log", ExactSpelling = true)]
        public static extern double log(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_logf", ExactSpelling = true)]
        public static extern float logf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log10", ExactSpelling = true)]
        public static extern double log10(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log10f", ExactSpelling = true)]
        public static extern float log10f(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_modf", ExactSpelling = true)]
        public static extern double modf(double x, double* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_modff", ExactSpelling = true)]
        public static extern float modff(float x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_pow", ExactSpelling = true)]
        public static extern double pow(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_powf", ExactSpelling = true)]
        public static extern float powf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_round", ExactSpelling = true)]
        public static extern double round(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_roundf", ExactSpelling = true)]
        public static extern float roundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lround", ExactSpelling = true)]
        public static extern nint lround(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lroundf", ExactSpelling = true)]
        public static extern nint lroundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_scalbn", ExactSpelling = true)]
        public static extern double scalbn(double x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_scalbnf", ExactSpelling = true)]
        public static extern float scalbnf(float x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sin", ExactSpelling = true)]
        public static extern double sin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sinf", ExactSpelling = true)]
        public static extern float sinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sqrt", ExactSpelling = true)]
        public static extern double sqrt(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sqrtf", ExactSpelling = true)]
        public static extern float sqrtf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tan", ExactSpelling = true)]
        public static extern double tan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tanf", ExactSpelling = true)]
        public static extern float tanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_open", ExactSpelling = true)]
        public static extern SDL_iconv_data_t* iconv_open(byte* tocode,byte* fromcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_close", ExactSpelling = true)]
        public static extern int iconv_close(SDL_iconv_data_t* cd);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv", ExactSpelling = true)]
        public static extern nuint iconv(SDL_iconv_data_t* cd,byte** inbuf,nuint* inbytesleft,byte** outbuf,nuint* outbytesleft);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_string", ExactSpelling = true)]
        public static extern byte* iconv_string(byte* tocode,byte* fromcode,byte* inbuf,nuint inbytesleft);
        public static bool8 size_mul_check_overflow(nuint a,nuint b,nuint* ret)
        {
            if (a != 0 && unchecked(b > 0xffffffffffffffffUL / a))
            {
                return (0) != 0;
            }

            *ret = a * b;
            return (1) != 0;
        }
        public static bool8 size_add_check_overflow(nuint a,nuint b,nuint* ret)
        {
            if (b > unchecked(0xffffffffffffffffUL - a))
            {
                return (0) != 0;
            }

            *ret = a + b;
            return (1) != 0;
        }
    }
}
