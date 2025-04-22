using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public unsafe partial struct SDL_alignment_test
    {
        [NativeTypeName("Uint8")]
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
        public static extern void* malloc([NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_calloc", ExactSpelling = true)]
        public static extern void* calloc([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_realloc", ExactSpelling = true)]
        public static extern void* realloc(void* mem, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_free", ExactSpelling = true)]
        public static extern void free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetOriginalMemoryFunctions", ExactSpelling = true)]
        public static extern void GetOriginalMemoryFunctions([NativeTypeName("SDL_malloc_func *")] delegate* unmanaged[Cdecl]<nuint, void*>* malloc_func, [NativeTypeName("SDL_calloc_func *")] delegate* unmanaged[Cdecl]<nuint, nuint, void*>* calloc_func, [NativeTypeName("SDL_realloc_func *")] delegate* unmanaged[Cdecl]<void*, nuint, void*>* realloc_func, [NativeTypeName("SDL_free_func *")] delegate* unmanaged[Cdecl]<void*, void>* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMemoryFunctions", ExactSpelling = true)]
        public static extern void GetMemoryFunctions([NativeTypeName("SDL_malloc_func *")] delegate* unmanaged[Cdecl]<nuint, void*>* malloc_func, [NativeTypeName("SDL_calloc_func *")] delegate* unmanaged[Cdecl]<nuint, nuint, void*>* calloc_func, [NativeTypeName("SDL_realloc_func *")] delegate* unmanaged[Cdecl]<void*, nuint, void*>* realloc_func, [NativeTypeName("SDL_free_func *")] delegate* unmanaged[Cdecl]<void*, void>* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetMemoryFunctions", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetMemoryFunctions([NativeTypeName("SDL_malloc_func")] delegate* unmanaged[Cdecl]<nuint, void*> malloc_func, [NativeTypeName("SDL_calloc_func")] delegate* unmanaged[Cdecl]<nuint, nuint, void*> calloc_func, [NativeTypeName("SDL_realloc_func")] delegate* unmanaged[Cdecl]<void*, nuint, void*> realloc_func, [NativeTypeName("SDL_free_func")] delegate* unmanaged[Cdecl]<void*, void> free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_alloc", ExactSpelling = true)]
        public static extern void* aligned_alloc([NativeTypeName("size_t")] nuint alignment, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_free", ExactSpelling = true)]
        public static extern void aligned_free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAllocations", ExactSpelling = true)]
        public static extern int GetNumAllocations();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironment", ExactSpelling = true)]
        public static extern SDL_Environment* GetEnvironment();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateEnvironment", ExactSpelling = true)]
        public static extern SDL_Environment* CreateEnvironment([NativeTypeName("_Bool")] bool8 populated);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariable", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* GetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariables", ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern byte** GetEnvironmentVariables(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEnvironmentVariable", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 SetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value, [NativeTypeName("_Bool")] bool8 overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnsetEnvironmentVariable", ExactSpelling = true)]
        [return: NativeTypeName("_Bool")]
        public static extern bool8 UnsetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyEnvironment", ExactSpelling = true)]
        public static extern void DestroyEnvironment(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* getenv([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv_unsafe", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* getenv_unsafe([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_setenv_unsafe", ExactSpelling = true)]
        public static extern int setenv_unsafe([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value, int overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_unsetenv_unsafe", ExactSpelling = true)]
        public static extern int unsetenv_unsafe([NativeTypeName("const char *")] byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort", ExactSpelling = true)]
        public static extern void qsort(void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("SDL_CompareCallback")] delegate* unmanaged[Cdecl]<void*, void*, int> compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch", ExactSpelling = true)]
        public static extern void* bsearch([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("SDL_CompareCallback")] delegate* unmanaged[Cdecl]<void*, void*, int> compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort_r", ExactSpelling = true)]
        public static extern void qsort_r(void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("SDL_CompareCallback_r")] delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch_r", ExactSpelling = true)]
        public static extern void* bsearch_r([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("SDL_CompareCallback_r")] delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

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
        [return: NativeTypeName("Uint16")]
        public static extern ushort crc16([NativeTypeName("Uint16")] ushort crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc32", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint crc32([NativeTypeName("Uint32")] uint crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_murmur3_32", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint murmur3_32([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len, [NativeTypeName("Uint32")] uint seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcpy", ExactSpelling = true)]
        public static extern void* memcpy(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memmove", ExactSpelling = true)]
        public static extern void* memmove(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memset", ExactSpelling = true)]
        public static extern void* memset(void* dst, int c, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memset4", ExactSpelling = true)]
        public static extern void* memset4(void* dst, [NativeTypeName("Uint32")] uint val, [NativeTypeName("size_t")] nuint dwords);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcmp", ExactSpelling = true)]
        public static extern int memcmp([NativeTypeName("const void *")] void* s1, [NativeTypeName("const void *")] void* s2, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint wcslen([NativeTypeName("const wchar_t *")] ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsnlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint wcsnlen([NativeTypeName("const wchar_t *")] ushort* wstr, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint wcslcpy([NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("const wchar_t *")] ushort* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcat", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint wcslcat([NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("const wchar_t *")] ushort* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsdup", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* wcsdup([NativeTypeName("const wchar_t *")] ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsstr", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* wcsstr([NativeTypeName("const wchar_t *")] ushort* haystack, [NativeTypeName("const wchar_t *")] ushort* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsnstr", ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* wcsnstr([NativeTypeName("const wchar_t *")] ushort* haystack, [NativeTypeName("const wchar_t *")] ushort* needle, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscmp", ExactSpelling = true)]
        public static extern int wcscmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncmp", ExactSpelling = true)]
        public static extern int wcsncmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscasecmp", ExactSpelling = true)]
        public static extern int wcscasecmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncasecmp", ExactSpelling = true)]
        public static extern int wcsncasecmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstol", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint wcstol([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("wchar_t **")] ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strlen([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strnlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strnlen([NativeTypeName("const char *")] byte* str, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strlcpy([NativeTypeName("char *")] byte* dst, [NativeTypeName("const char *")] byte* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlcpy", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint utf8strlcpy([NativeTypeName("char *")] byte* dst, [NativeTypeName("const char *")] byte* src, [NativeTypeName("size_t")] nuint dst_bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcat", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint strlcat([NativeTypeName("char *")] byte* dst, [NativeTypeName("const char *")] byte* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strdup", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strdup([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strndup", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strndup([NativeTypeName("const char *")] byte* str, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrev", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strrev([NativeTypeName("char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strupr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strupr([NativeTypeName("char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlwr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strlwr([NativeTypeName("char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strchr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strchr([NativeTypeName("const char *")] byte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrchr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strrchr([NativeTypeName("const char *")] byte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strstr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strstr([NativeTypeName("const char *")] byte* haystack, [NativeTypeName("const char *")] byte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strnstr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strnstr([NativeTypeName("const char *")] byte* haystack, [NativeTypeName("const char *")] byte* needle, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasestr", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strcasestr([NativeTypeName("const char *")] byte* haystack, [NativeTypeName("const char *")] byte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtok_r", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strtok_r([NativeTypeName("char *")] byte* str, [NativeTypeName("const char *")] byte* delim, [NativeTypeName("char **")] byte** saveptr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint utf8strlen([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strnlen", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint utf8strnlen([NativeTypeName("const char *")] byte* str, [NativeTypeName("size_t")] nuint bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_itoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* itoa(int value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_uitoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* uitoa([NativeTypeName("unsigned int")] uint value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* ltoa([NativeTypeName("long")] nint value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ultoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* ultoa([NativeTypeName("unsigned long")] nuint value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* lltoa([NativeTypeName("long long")] long value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ulltoa", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* ulltoa([NativeTypeName("unsigned long long")] ulong value, [NativeTypeName("char *")] byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atoi", ExactSpelling = true)]
        public static extern int atoi([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atof", ExactSpelling = true)]
        public static extern double atof([NativeTypeName("const char *")] byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtol", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint strtol([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoul", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint strtoul([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoll", ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long strtoll([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoull", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong strtoull([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtod", ExactSpelling = true)]
        public static extern double strtod([NativeTypeName("const char *")] byte* str, [NativeTypeName("char **")] byte** endp);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcmp", ExactSpelling = true)]
        public static extern int strcmp([NativeTypeName("const char *")] byte* str1, [NativeTypeName("const char *")] byte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncmp", ExactSpelling = true)]
        public static extern int strncmp([NativeTypeName("const char *")] byte* str1, [NativeTypeName("const char *")] byte* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasecmp", ExactSpelling = true)]
        public static extern int strcasecmp([NativeTypeName("const char *")] byte* str1, [NativeTypeName("const char *")] byte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncasecmp", ExactSpelling = true)]
        public static extern int strncasecmp([NativeTypeName("const char *")] byte* str1, [NativeTypeName("const char *")] byte* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strpbrk", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* strpbrk([NativeTypeName("const char *")] byte* str, [NativeTypeName("const char *")] byte* breakset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StepUTF8", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint StepUTF8([NativeTypeName("const char **")] byte** pstr, [NativeTypeName("size_t *")] nuint* pslen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StepBackUTF8", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint StepBackUTF8([NativeTypeName("const char *")] byte* start, [NativeTypeName("const char **")] byte** pstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UCS4ToUTF8", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* UCS4ToUTF8([NativeTypeName("Uint32")] uint codepoint, [NativeTypeName("char *")] byte* dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sscanf", ExactSpelling = true)]
        public static extern int sscanf([NativeTypeName("const char *")] byte* text, [NativeTypeName("const char *")] byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vsscanf", ExactSpelling = true)]
        public static extern int vsscanf([NativeTypeName("const char *")] byte* text, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_snprintf", ExactSpelling = true)]
        public static extern int snprintf([NativeTypeName("char *")] byte* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const char *")] byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_swprintf", ExactSpelling = true)]
        public static extern int swprintf([NativeTypeName("wchar_t *")] ushort* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const wchar_t *")] ushort* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vsnprintf", ExactSpelling = true)]
        public static extern int vsnprintf([NativeTypeName("char *")] byte* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vswprintf", ExactSpelling = true)]
        public static extern int vswprintf([NativeTypeName("wchar_t *")] ushort* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const wchar_t *")] ushort* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asprintf", ExactSpelling = true)]
        public static extern int asprintf([NativeTypeName("char **")] byte** strp, [NativeTypeName("const char *")] byte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vasprintf", ExactSpelling = true)]
        public static extern int vasprintf([NativeTypeName("char **")] byte** strp, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_srand", ExactSpelling = true)]
        public static extern void srand([NativeTypeName("Uint64")] ulong seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand", ExactSpelling = true)]
        [return: NativeTypeName("Sint32")]
        public static extern int rand([NativeTypeName("Sint32")] int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_randf", ExactSpelling = true)]
        public static extern float randf();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_bits", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint rand_bits();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_r", ExactSpelling = true)]
        [return: NativeTypeName("Sint32")]
        public static extern int rand_r([NativeTypeName("Uint64 *")] ulong* state, [NativeTypeName("Sint32")] int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_randf_r", ExactSpelling = true)]
        public static extern float randf_r([NativeTypeName("Uint64 *")] ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_bits_r", ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint rand_bits_r([NativeTypeName("Uint64 *")] ulong* state);

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
        [return: NativeTypeName("long")]
        public static extern nint lround(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lroundf", ExactSpelling = true)]
        [return: NativeTypeName("long")]
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
        [return: NativeTypeName("SDL_iconv_t")]
        public static extern SDL_iconv_data_t* iconv_open([NativeTypeName("const char *")] byte* tocode, [NativeTypeName("const char *")] byte* fromcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_close", ExactSpelling = true)]
        public static extern int iconv_close([NativeTypeName("SDL_iconv_t")] SDL_iconv_data_t* cd);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint iconv([NativeTypeName("SDL_iconv_t")] SDL_iconv_data_t* cd, [NativeTypeName("const char **")] byte** inbuf, [NativeTypeName("size_t *")] nuint* inbytesleft, [NativeTypeName("char **")] byte** outbuf, [NativeTypeName("size_t *")] nuint* outbytesleft);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_string", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern byte* iconv_string([NativeTypeName("const char *")] byte* tocode, [NativeTypeName("const char *")] byte* fromcode, [NativeTypeName("const char *")] byte* inbuf, [NativeTypeName("size_t")] nuint inbytesleft);

        [return: NativeTypeName("_Bool")]
        public static bool8 size_mul_check_overflow([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
        {
            if (a != 0 && unchecked(b > 0xffffffffffffffffUL / a))
            {
                return (0) != 0;
            }

            *ret = a * b;
            return (1) != 0;
        }

        [return: NativeTypeName("_Bool")]
        public static bool8 size_add_check_overflow([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
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
