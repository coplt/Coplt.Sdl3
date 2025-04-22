using System.Runtime.InteropServices;

namespace Coplt.Sdl3;

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
    public static extern byte SetMemoryFunctions([NativeTypeName("SDL_malloc_func")] delegate* unmanaged[Cdecl]<nuint, void*> malloc_func, [NativeTypeName("SDL_calloc_func")] delegate* unmanaged[Cdecl]<nuint, nuint, void*> calloc_func, [NativeTypeName("SDL_realloc_func")] delegate* unmanaged[Cdecl]<void*, nuint, void*> realloc_func, [NativeTypeName("SDL_free_func")] delegate* unmanaged[Cdecl]<void*, void> free_func);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_alloc", ExactSpelling = true)]
    public static extern void* aligned_alloc([NativeTypeName("size_t")] nuint alignment, [NativeTypeName("size_t")] nuint size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_free", ExactSpelling = true)]
    public static extern void aligned_free(void* mem);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAllocations", ExactSpelling = true)]
    public static extern int GetNumAllocations();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironment", ExactSpelling = true)]
    public static extern SDL_Environment* GetEnvironment();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateEnvironment", ExactSpelling = true)]
    public static extern SDL_Environment* CreateEnvironment([NativeTypeName("_Bool")] byte populated);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariable", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariables", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern byte** GetEnvironmentVariables(SDL_Environment* env);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEnvironmentVariable", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value, [NativeTypeName("_Bool")] byte overwrite);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnsetEnvironmentVariable", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte UnsetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] byte* name);

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
    public static bool size_mul_check_overflow([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
    {
        if (a != 0 && unchecked(b > 0xffffffffffffffffUL / a))
        {
            return (0) != 0;
        }

        *ret = a * b;
        return (1) != 0;
    }

    [return: NativeTypeName("_Bool")]
    public static bool size_add_check_overflow([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
    {
        if (b > unchecked(0xffffffffffffffffUL - a))
        {
            return (0) != 0;
        }

        *ret = a + b;
        return (1) != 0;
    }

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReportAssertion", ExactSpelling = true)]
    public static extern SDL_AssertState ReportAssertion(SDL_AssertData* data, [NativeTypeName("const char *")] byte* func, [NativeTypeName("const char *")] byte* file, int line);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAssertionHandler", ExactSpelling = true)]
    public static extern void SetAssertionHandler([NativeTypeName("SDL_AssertionHandler")] delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> handler, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultAssertionHandler", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AssertionHandler")]
    public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetDefaultAssertionHandler();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionHandler", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AssertionHandler")]
    public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetAssertionHandler(void** puserdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionReport", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_AssertData *")]
    public static extern SDL_AssertData* GetAssertionReport();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetAssertionReport", ExactSpelling = true)]
    public static extern void ResetAssertionReport();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AsyncIOFromFile", ExactSpelling = true)]
    public static extern SDL_AsyncIO* AsyncIOFromFile([NativeTypeName("const char *")] byte* file, [NativeTypeName("const char *")] byte* mode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAsyncIOSize", ExactSpelling = true)]
    [return: NativeTypeName("Sint64")]
    public static extern long GetAsyncIOSize(SDL_AsyncIO* asyncio);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadAsyncIO", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadAsyncIO(SDL_AsyncIO* asyncio, void* ptr, [NativeTypeName("Uint64")] ulong offset, [NativeTypeName("Uint64")] ulong size, SDL_AsyncIOQueue* queue, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteAsyncIO", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteAsyncIO(SDL_AsyncIO* asyncio, void* ptr, [NativeTypeName("Uint64")] ulong offset, [NativeTypeName("Uint64")] ulong size, SDL_AsyncIOQueue* queue, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseAsyncIO", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CloseAsyncIO(SDL_AsyncIO* asyncio, [NativeTypeName("_Bool")] byte flush, SDL_AsyncIOQueue* queue, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateAsyncIOQueue", ExactSpelling = true)]
    public static extern SDL_AsyncIOQueue* CreateAsyncIOQueue();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyAsyncIOQueue", ExactSpelling = true)]
    public static extern void DestroyAsyncIOQueue(SDL_AsyncIOQueue* queue);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAsyncIOResult", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitAsyncIOResult", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome, [NativeTypeName("Sint32")] int timeoutMS);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalAsyncIOQueue", ExactSpelling = true)]
    public static extern void SignalAsyncIOQueue(SDL_AsyncIOQueue* queue);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFileAsync", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte LoadFileAsync([NativeTypeName("const char *")] byte* file, SDL_AsyncIOQueue* queue, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockSpinlock", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockSpinlock", ExactSpelling = true)]
    public static extern void LockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockSpinlock", ExactSpelling = true)]
    public static extern void UnlockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MemoryBarrierReleaseFunction", ExactSpelling = true)]
    public static extern void MemoryBarrierReleaseFunction();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MemoryBarrierAcquireFunction", ExactSpelling = true)]
    public static extern void MemoryBarrierAcquireFunction();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicInt", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CompareAndSwapAtomicInt(SDL_AtomicInt* a, int oldval, int newval);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicInt", ExactSpelling = true)]
    public static extern int SetAtomicInt(SDL_AtomicInt* a, int v);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicInt", ExactSpelling = true)]
    public static extern int GetAtomicInt(SDL_AtomicInt* a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddAtomicInt", ExactSpelling = true)]
    public static extern int AddAtomicInt(SDL_AtomicInt* a, int v);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicU32", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CompareAndSwapAtomicU32(SDL_AtomicU32* a, [NativeTypeName("Uint32")] uint oldval, [NativeTypeName("Uint32")] uint newval);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicU32", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SetAtomicU32(SDL_AtomicU32* a, [NativeTypeName("Uint32")] uint v);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicU32", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetAtomicU32(SDL_AtomicU32* a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicPointer", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicPointer", ExactSpelling = true)]
    public static extern void* SetAtomicPointer(void** a, void* v);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicPointer", ExactSpelling = true)]
    public static extern void* GetAtomicPointer(void** a);

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
    public static extern byte GetAudioDeviceFormat([NativeTypeName("SDL_AudioDeviceID")] uint devid, SDL_AudioSpec* spec, int* sample_frames);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceChannelMap", ExactSpelling = true)]
    public static extern int* GetAudioDeviceChannelMap([NativeTypeName("SDL_AudioDeviceID")] uint devid, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenAudioDevice", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AudioDeviceID")]
    public static extern uint OpenAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsAudioDevicePhysical", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsAudioDevicePhysical([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsAudioDevicePlayback", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsAudioDevicePlayback([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseAudioDevice", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeAudioDevice", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ResumeAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioDevicePaused", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte AudioDevicePaused([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceGain", ExactSpelling = true)]
    public static extern float GetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioDeviceGain", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid, float gain);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseAudioDevice", ExactSpelling = true)]
    public static extern void CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindAudioStreams", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BindAudioStreams([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("SDL_AudioStream *const *")] SDL_AudioStream** streams, int num_streams);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindAudioStream", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BindAudioStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, SDL_AudioStream* stream);

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
    public static extern byte GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamFormat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioStreamFormat(SDL_AudioStream* stream, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamFrequencyRatio", ExactSpelling = true)]
    public static extern float GetAudioStreamFrequencyRatio(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamFrequencyRatio", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamGain", ExactSpelling = true)]
    public static extern float GetAudioStreamGain(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamGain", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioStreamGain(SDL_AudioStream* stream, float gain);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamInputChannelMap", ExactSpelling = true)]
    public static extern int* GetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamOutputChannelMap", ExactSpelling = true)]
    public static extern int* GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamInputChannelMap", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioStreamInputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamOutputChannelMap", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PutAudioStreamData", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PutAudioStreamData(SDL_AudioStream* stream, [NativeTypeName("const void *")] void* buf, int len);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamData", ExactSpelling = true)]
    public static extern int GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamAvailable", ExactSpelling = true)]
    public static extern int GetAudioStreamAvailable(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioStreamQueued", ExactSpelling = true)]
    public static extern int GetAudioStreamQueued(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushAudioStream", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte FlushAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearAudioStream", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ClearAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseAudioStreamDevice", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PauseAudioStreamDevice(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeAudioStreamDevice", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ResumeAudioStreamDevice(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AudioStreamDevicePaused", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte AudioStreamDevicePaused(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockAudioStream", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte LockAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockAudioStream", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte UnlockAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamGetCallback", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioStreamGetCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioStreamPutCallback", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioStreamPutCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyAudioStream", ExactSpelling = true)]
    public static extern void DestroyAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenAudioDeviceStream", ExactSpelling = true)]
    public static extern SDL_AudioStream* OpenAudioDeviceStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAudioPostmixCallback", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAudioPostmixCallback([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("SDL_AudioPostmixCallback")] delegate* unmanaged[Cdecl]<void*, SDL_AudioSpec*, float*, int, void> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadWAV_IO", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte LoadWAV_IO(SDL_IOStream* src, [NativeTypeName("_Bool")] byte closeio, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadWAV", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte LoadWAV([NativeTypeName("const char *")] byte* path, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MixAudio", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte MixAudio([NativeTypeName("Uint8 *")] byte* dst, [NativeTypeName("const Uint8 *")] byte* src, SDL_AudioFormat format, [NativeTypeName("Uint32")] uint len, float volume);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertAudioSamples", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ConvertAudioSamples([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const Uint8 *")] byte* src_data, int src_len, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec, [NativeTypeName("Uint8 **")] byte** dst_data, int* dst_len);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioFormatName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetAudioFormatName(SDL_AudioFormat format);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSilenceValueForFormat", ExactSpelling = true)]
    public static extern int GetSilenceValueForFormat(SDL_AudioFormat format);

    public static int MostSignificantBitIndex32([NativeTypeName("Uint32")] uint x)
    {
        if (x == 0)
        {
            return -1;
        }

        return 31 - __builtin_clz(x);
    }

    [return: NativeTypeName("_Bool")]
    public static bool HasExactlyOneBitSet32([NativeTypeName("Uint32")] uint x)
    {
        if ((x != 0) && (x & (x - 1)) == 0)
        {
            return (1) != 0;
        }

        return (0) != 0;
    }

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ComposeCustomBlendMode", ExactSpelling = true)]
    [return: NativeTypeName("SDL_BlendMode")]
    public static extern uint ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumCameraDrivers", ExactSpelling = true)]
    public static extern int GetNumCameraDrivers();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraDriver", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetCameraDriver(int index);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentCameraDriver", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetCurrentCameraDriver();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameras", ExactSpelling = true)]
    [return: NativeTypeName("SDL_CameraID *")]
    public static extern uint* GetCameras(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraSupportedFormats", ExactSpelling = true)]
    public static extern SDL_CameraSpec** GetCameraSupportedFormats([NativeTypeName("SDL_CameraID")] uint instance_id, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetCameraName([NativeTypeName("SDL_CameraID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraPosition", ExactSpelling = true)]
    public static extern SDL_CameraPosition GetCameraPosition([NativeTypeName("SDL_CameraID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenCamera", ExactSpelling = true)]
    public static extern SDL_Camera* OpenCamera([NativeTypeName("SDL_CameraID")] uint instance_id, [NativeTypeName("const SDL_CameraSpec *")] SDL_CameraSpec* spec);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraPermissionState", ExactSpelling = true)]
    public static extern int GetCameraPermissionState(SDL_Camera* camera);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraID", ExactSpelling = true)]
    [return: NativeTypeName("SDL_CameraID")]
    public static extern uint GetCameraID(SDL_Camera* camera);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetCameraProperties(SDL_Camera* camera);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCameraFormat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetCameraFormat(SDL_Camera* camera, SDL_CameraSpec* spec);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireCameraFrame", ExactSpelling = true)]
    public static extern SDL_Surface* AcquireCameraFrame(SDL_Camera* camera, [NativeTypeName("Uint64 *")] ulong* timestampNS);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseCameraFrame", ExactSpelling = true)]
    public static extern void ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseCamera", ExactSpelling = true)]
    public static extern void CloseCamera(SDL_Camera* camera);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardText", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetClipboardText([NativeTypeName("const char *")] byte* text);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardText", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern byte* GetClipboardText();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardText", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasClipboardText();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPrimarySelectionText", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetPrimarySelectionText([NativeTypeName("const char *")] byte* text);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimarySelectionText", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern byte* GetPrimarySelectionText();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasPrimarySelectionText", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasPrimarySelectionText();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardData", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetClipboardData([NativeTypeName("SDL_ClipboardDataCallback")] delegate* unmanaged[Cdecl]<void*, byte*, nuint*, void*> callback, [NativeTypeName("SDL_ClipboardCleanupCallback")] delegate* unmanaged[Cdecl]<void*, void> cleanup, void* userdata, [NativeTypeName("const char **")] byte** mime_types, [NativeTypeName("size_t")] nuint num_mime_types);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearClipboardData", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ClearClipboardData();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardData", ExactSpelling = true)]
    public static extern void* GetClipboardData([NativeTypeName("const char *")] byte* mime_type, [NativeTypeName("size_t *")] nuint* size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardData", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasClipboardData([NativeTypeName("const char *")] byte* mime_type);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardMimeTypes", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern byte** GetClipboardMimeTypes([NativeTypeName("size_t *")] nuint* num_mime_types);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumLogicalCPUCores", ExactSpelling = true)]
    public static extern int GetNumLogicalCPUCores();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCPUCacheLineSize", ExactSpelling = true)]
    public static extern int GetCPUCacheLineSize();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAltiVec", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasAltiVec();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasMMX", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasMMX();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasSSE();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE2", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasSSE2();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE3", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasSSE3();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE41", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasSSE41();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE42", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasSSE42();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasAVX();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX2", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasAVX2();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX512F", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasAVX512F();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasARMSIMD", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasARMSIMD();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasNEON", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasNEON();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLSX", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasLSX();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLASX", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasLASX();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemRAM", ExactSpelling = true)]
    public static extern int GetSystemRAM();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSIMDAlignment", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint GetSIMDAlignment();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowOpenFileDialog", ExactSpelling = true)]
    public static extern void ShowOpenFileDialog([NativeTypeName("SDL_DialogFileCallback")] delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window, [NativeTypeName("const SDL_DialogFileFilter *")] SDL_DialogFileFilter* filters, int nfilters, [NativeTypeName("const char *")] byte* default_location, [NativeTypeName("_Bool")] byte allow_many);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSaveFileDialog", ExactSpelling = true)]
    public static extern void ShowSaveFileDialog([NativeTypeName("SDL_DialogFileCallback")] delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window, [NativeTypeName("const SDL_DialogFileFilter *")] SDL_DialogFileFilter* filters, int nfilters, [NativeTypeName("const char *")] byte* default_location);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowOpenFolderDialog", ExactSpelling = true)]
    public static extern void ShowOpenFolderDialog([NativeTypeName("SDL_DialogFileCallback")] delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, SDL_Window* window, [NativeTypeName("const char *")] byte* default_location, [NativeTypeName("_Bool")] byte allow_many);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowFileDialogWithProperties", ExactSpelling = true)]
    public static extern void ShowFileDialogWithProperties(SDL_FileDialogType type, [NativeTypeName("SDL_DialogFileCallback")] delegate* unmanaged[Cdecl]<void*, byte**, int, void> callback, void* userdata, [NativeTypeName("SDL_PropertiesID")] uint props);

    public static float SwapFloat(float x)
    {
        SDL_SwapFloat_Union swapper;

        swapper.ui32 = 0;
        swapper.f = x;
        swapper.ui32 = __builtin_bswap32(swapper.ui32);
        return swapper.f;
    }

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetError", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetError([NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetErrorV", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetErrorV([NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OutOfMemory", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte OutOfMemory();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetError", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetError();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearError", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ClearError();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PumpEvents", ExactSpelling = true)]
    public static extern void PumpEvents();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PeepEvents", ExactSpelling = true)]
    public static extern int PeepEvents(SDL_Event* events, int numevents, SDL_EventAction action, [NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvent", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasEvent([NativeTypeName("Uint32")] uint type);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvents", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasEvents([NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushEvent", ExactSpelling = true)]
    public static extern void FlushEvent([NativeTypeName("Uint32")] uint type);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushEvents", ExactSpelling = true)]
    public static extern void FlushEvents([NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PollEvent", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PollEvent(SDL_Event* @event);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitEvent", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitEvent(SDL_Event* @event);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitEventTimeout", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitEventTimeout(SDL_Event* @event, [NativeTypeName("Sint32")] int timeoutMS);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushEvent", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PushEvent(SDL_Event* @event);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEventFilter", ExactSpelling = true)]
    public static extern void SetEventFilter([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEventFilter", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetEventFilter([NativeTypeName("SDL_EventFilter *")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte>* filter, void** userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddEventWatch", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte AddEventWatch([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveEventWatch", ExactSpelling = true)]
    public static extern void RemoveEventWatch([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FilterEvents", ExactSpelling = true)]
    public static extern void FilterEvents([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEventEnabled", ExactSpelling = true)]
    public static extern void SetEventEnabled([NativeTypeName("Uint32")] uint type, [NativeTypeName("_Bool")] byte enabled);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EventEnabled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte EventEnabled([NativeTypeName("Uint32")] uint type);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RegisterEvents", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint RegisterEvents(int numevents);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFromEvent", ExactSpelling = true)]
    public static extern SDL_Window* GetWindowFromEvent([NativeTypeName("const SDL_Event *")] SDL_Event* @event);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBasePath", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetBasePath();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrefPath", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern byte* GetPrefPath([NativeTypeName("const char *")] byte* org, [NativeTypeName("const char *")] byte* app);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetUserFolder", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetUserFolder(SDL_Folder folder);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateDirectory", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CreateDirectory([NativeTypeName("const char *")] byte* path);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateDirectory", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte EnumerateDirectory([NativeTypeName("const char *")] byte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] delegate* unmanaged[Cdecl]<void*, byte*, byte*, SDL_EnumerationResult> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemovePath", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RemovePath([NativeTypeName("const char *")] byte* path);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenamePath", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenamePath([NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyFile", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CopyFile([NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPathInfo", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetPathInfo([NativeTypeName("const char *")] byte* path, SDL_PathInfo* info);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobDirectory", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern byte** GlobDirectory([NativeTypeName("const char *")] byte* path, [NativeTypeName("const char *")] byte* pattern, [NativeTypeName("SDL_GlobFlags")] uint flags, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDirectory", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern byte* GetCurrentDirectory();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMapping", ExactSpelling = true)]
    public static extern int AddGamepadMapping([NativeTypeName("const char *")] byte* mapping);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMappingsFromIO", ExactSpelling = true)]
    public static extern int AddGamepadMappingsFromIO(SDL_IOStream* src, [NativeTypeName("_Bool")] byte closeio);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMappingsFromFile", ExactSpelling = true)]
    public static extern int AddGamepadMappingsFromFile([NativeTypeName("const char *")] byte* file);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReloadGamepadMappings", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReloadGamepadMappings();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappings", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern byte** GetGamepadMappings(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForGUID", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern byte* GetGamepadMappingForGUID(SDL_GUID guid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMapping", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern byte* GetGamepadMapping(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadMapping", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetGamepadMapping([NativeTypeName("SDL_JoystickID")] uint instance_id, [NativeTypeName("const char *")] byte* mapping);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasGamepad", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasGamepad();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepads", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID *")]
    public static extern uint* GetGamepads(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsGamepad", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadNameForID", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadNameForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPathForID", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadPathForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPlayerIndexForID", ExactSpelling = true)]
    public static extern int GetGamepadPlayerIndexForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadGUIDForID", ExactSpelling = true)]
    public static extern SDL_GUID GetGamepadGUIDForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadVendorForID", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadVendorForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductForID", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadProductForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductVersionForID", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadProductVersionForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTypeForID", ExactSpelling = true)]
    public static extern SDL_GamepadType GetGamepadTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadTypeForID", ExactSpelling = true)]
    public static extern SDL_GamepadType GetRealGamepadTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForID", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern byte* GetGamepadMappingForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenGamepad", ExactSpelling = true)]
    public static extern SDL_Gamepad* OpenGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromID", ExactSpelling = true)]
    public static extern SDL_Gamepad* GetGamepadFromID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromPlayerIndex", ExactSpelling = true)]
    public static extern SDL_Gamepad* GetGamepadFromPlayerIndex(int player_index);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetGamepadProperties(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadID", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint GetGamepadID(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadName(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPath", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadPath(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadType", ExactSpelling = true)]
    public static extern SDL_GamepadType GetGamepadType(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadType", ExactSpelling = true)]
    public static extern SDL_GamepadType GetRealGamepadType(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPlayerIndex", ExactSpelling = true)]
    public static extern int GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadPlayerIndex", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadVendor", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadVendor(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProduct", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadProduct(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductVersion", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadProductVersion(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFirmwareVersion", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSerial", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadSerial(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSteamHandle", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetGamepadSteamHandle(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadConnectionState", ExactSpelling = true)]
    public static extern SDL_JoystickConnectionState GetGamepadConnectionState(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPowerInfo", ExactSpelling = true)]
    public static extern SDL_PowerState GetGamepadPowerInfo(SDL_Gamepad* gamepad, int* percent);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadConnected", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GamepadConnected(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadJoystick", ExactSpelling = true)]
    public static extern SDL_Joystick* GetGamepadJoystick(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadEventsEnabled", ExactSpelling = true)]
    public static extern void SetGamepadEventsEnabled([NativeTypeName("_Bool")] byte enabled);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadEventsEnabled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GamepadEventsEnabled();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadBindings", ExactSpelling = true)]
    public static extern SDL_GamepadBinding** GetGamepadBindings(SDL_Gamepad* gamepad, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateGamepads", ExactSpelling = true)]
    public static extern void UpdateGamepads();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTypeFromString", ExactSpelling = true)]
    public static extern SDL_GamepadType GetGamepadTypeFromString([NativeTypeName("const char *")] byte* str);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForType", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadStringForType(SDL_GamepadType type);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAxisFromString", ExactSpelling = true)]
    public static extern SDL_GamepadAxis GetGamepadAxisFromString([NativeTypeName("const char *")] byte* str);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForAxis", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadStringForAxis(SDL_GamepadAxis axis);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasAxis", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAxis", ExactSpelling = true)]
    [return: NativeTypeName("Sint16")]
    public static extern short GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonFromString", ExactSpelling = true)]
    public static extern SDL_GamepadButton GetGamepadButtonFromString([NativeTypeName("const char *")] byte* str);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForButton", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadStringForButton(SDL_GamepadButton button);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasButton", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButton", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonLabelForType", ExactSpelling = true)]
    public static extern SDL_GamepadButtonLabel GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonLabel", ExactSpelling = true)]
    public static extern SDL_GamepadButtonLabel GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadTouchpads", ExactSpelling = true)]
    public static extern int GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadTouchpadFingers", ExactSpelling = true)]
    public static extern int GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTouchpadFinger", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, [NativeTypeName("_Bool *")] bool* down, float* x, float* y, float* pressure);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasSensor", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadSensorEnabled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, [NativeTypeName("_Bool")] byte enabled);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadSensorEnabled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSensorDataRate", ExactSpelling = true)]
    public static extern float GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSensorData", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int num_values);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleGamepad", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RumbleGamepad(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleGamepadTriggers", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RumbleGamepadTriggers(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadLED", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetGamepadLED(SDL_Gamepad* gamepad, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendGamepadEffect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SendGamepadEffect(SDL_Gamepad* gamepad, [NativeTypeName("const void *")] void* data, int size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseGamepad", ExactSpelling = true)]
    public static extern void CloseGamepad(SDL_Gamepad* gamepad);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUSupportsShaderFormats", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GPUSupportsShaderFormats([NativeTypeName("SDL_GPUShaderFormat")] uint format_flags, [NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUSupportsProperties", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GPUSupportsProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUDevice", ExactSpelling = true)]
    public static extern SDL_GPUDevice* CreateGPUDevice([NativeTypeName("SDL_GPUShaderFormat")] uint format_flags, [NativeTypeName("_Bool")] byte debug_mode, [NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUDeviceWithProperties", ExactSpelling = true)]
    public static extern SDL_GPUDevice* CreateGPUDeviceWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyGPUDevice", ExactSpelling = true)]
    public static extern void DestroyGPUDevice(SDL_GPUDevice* device);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGPUDrivers", ExactSpelling = true)]
    public static extern int GetNumGPUDrivers();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUDriver", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGPUDriver(int index);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUDeviceDriver", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetGPUDeviceDriver(SDL_GPUDevice* device);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUShaderFormats", ExactSpelling = true)]
    [return: NativeTypeName("SDL_GPUShaderFormat")]
    public static extern uint GetGPUShaderFormats(SDL_GPUDevice* device);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUComputePipeline", ExactSpelling = true)]
    public static extern SDL_GPUComputePipeline* CreateGPUComputePipeline(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUComputePipelineCreateInfo *")] SDL_GPUComputePipelineCreateInfo* createinfo);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUGraphicsPipeline", ExactSpelling = true)]
    public static extern SDL_GPUGraphicsPipeline* CreateGPUGraphicsPipeline(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUGraphicsPipelineCreateInfo *")] SDL_GPUGraphicsPipelineCreateInfo* createinfo);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUSampler", ExactSpelling = true)]
    public static extern SDL_GPUSampler* CreateGPUSampler(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUSamplerCreateInfo *")] SDL_GPUSamplerCreateInfo* createinfo);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUShader", ExactSpelling = true)]
    public static extern SDL_GPUShader* CreateGPUShader(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUShaderCreateInfo *")] SDL_GPUShaderCreateInfo* createinfo);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUTexture", ExactSpelling = true)]
    public static extern SDL_GPUTexture* CreateGPUTexture(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUTextureCreateInfo *")] SDL_GPUTextureCreateInfo* createinfo);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUBuffer", ExactSpelling = true)]
    public static extern SDL_GPUBuffer* CreateGPUBuffer(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUBufferCreateInfo *")] SDL_GPUBufferCreateInfo* createinfo);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUTransferBuffer", ExactSpelling = true)]
    public static extern SDL_GPUTransferBuffer* CreateGPUTransferBuffer(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUTransferBufferCreateInfo *")] SDL_GPUTransferBufferCreateInfo* createinfo);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUBufferName", ExactSpelling = true)]
    public static extern void SetGPUBufferName(SDL_GPUDevice* device, SDL_GPUBuffer* buffer, [NativeTypeName("const char *")] byte* text);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUTextureName", ExactSpelling = true)]
    public static extern void SetGPUTextureName(SDL_GPUDevice* device, SDL_GPUTexture* texture, [NativeTypeName("const char *")] byte* text);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InsertGPUDebugLabel", ExactSpelling = true)]
    public static extern void InsertGPUDebugLabel(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const char *")] byte* text);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUDebugGroup", ExactSpelling = true)]
    public static extern void PushGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PopGPUDebugGroup", ExactSpelling = true)]
    public static extern void PopGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUTexture", ExactSpelling = true)]
    public static extern void ReleaseGPUTexture(SDL_GPUDevice* device, SDL_GPUTexture* texture);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUSampler", ExactSpelling = true)]
    public static extern void ReleaseGPUSampler(SDL_GPUDevice* device, SDL_GPUSampler* sampler);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUBuffer", ExactSpelling = true)]
    public static extern void ReleaseGPUBuffer(SDL_GPUDevice* device, SDL_GPUBuffer* buffer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUTransferBuffer", ExactSpelling = true)]
    public static extern void ReleaseGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUComputePipeline", ExactSpelling = true)]
    public static extern void ReleaseGPUComputePipeline(SDL_GPUDevice* device, SDL_GPUComputePipeline* compute_pipeline);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUShader", ExactSpelling = true)]
    public static extern void ReleaseGPUShader(SDL_GPUDevice* device, SDL_GPUShader* shader);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUGraphicsPipeline", ExactSpelling = true)]
    public static extern void ReleaseGPUGraphicsPipeline(SDL_GPUDevice* device, SDL_GPUGraphicsPipeline* graphics_pipeline);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireGPUCommandBuffer", ExactSpelling = true)]
    public static extern SDL_GPUCommandBuffer* AcquireGPUCommandBuffer(SDL_GPUDevice* device);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUVertexUniformData", ExactSpelling = true)]
    public static extern void PushGPUVertexUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUFragmentUniformData", ExactSpelling = true)]
    public static extern void PushGPUFragmentUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUComputeUniformData", ExactSpelling = true)]
    public static extern void PushGPUComputeUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPURenderPass", ExactSpelling = true)]
    public static extern SDL_GPURenderPass* BeginGPURenderPass(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUColorTargetInfo *")] SDL_GPUColorTargetInfo* color_target_infos, [NativeTypeName("Uint32")] uint num_color_targets, [NativeTypeName("const SDL_GPUDepthStencilTargetInfo *")] SDL_GPUDepthStencilTargetInfo* depth_stencil_target_info);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUGraphicsPipeline", ExactSpelling = true)]
    public static extern void BindGPUGraphicsPipeline(SDL_GPURenderPass* render_pass, SDL_GPUGraphicsPipeline* graphics_pipeline);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUViewport", ExactSpelling = true)]
    public static extern void SetGPUViewport(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_GPUViewport *")] SDL_GPUViewport* viewport);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUScissor", ExactSpelling = true)]
    public static extern void SetGPUScissor(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_Rect *")] SDL_Rect* scissor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUBlendConstants", ExactSpelling = true)]
    public static extern void SetGPUBlendConstants(SDL_GPURenderPass* render_pass, SDL_FColor blend_constants);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUStencilReference", ExactSpelling = true)]
    public static extern void SetGPUStencilReference(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint8")] byte reference);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexBuffers", ExactSpelling = true)]
    public static extern void BindGPUVertexBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUBufferBinding *")] SDL_GPUBufferBinding* bindings, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUIndexBuffer", ExactSpelling = true)]
    public static extern void BindGPUIndexBuffer(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_GPUBufferBinding *")] SDL_GPUBufferBinding* binding, SDL_GPUIndexElementSize index_element_size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexSamplers", ExactSpelling = true)]
    public static extern void BindGPUVertexSamplers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexStorageTextures", ExactSpelling = true)]
    public static extern void BindGPUVertexStorageTextures(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexStorageBuffers", ExactSpelling = true)]
    public static extern void BindGPUVertexStorageBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentSamplers", ExactSpelling = true)]
    public static extern void BindGPUFragmentSamplers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentStorageTextures", ExactSpelling = true)]
    public static extern void BindGPUFragmentStorageTextures(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentStorageBuffers", ExactSpelling = true)]
    public static extern void BindGPUFragmentStorageBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUIndexedPrimitives", ExactSpelling = true)]
    public static extern void DrawGPUIndexedPrimitives(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint num_indices, [NativeTypeName("Uint32")] uint num_instances, [NativeTypeName("Uint32")] uint first_index, [NativeTypeName("Sint32")] int vertex_offset, [NativeTypeName("Uint32")] uint first_instance);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUPrimitives", ExactSpelling = true)]
    public static extern void DrawGPUPrimitives(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint num_vertices, [NativeTypeName("Uint32")] uint num_instances, [NativeTypeName("Uint32")] uint first_vertex, [NativeTypeName("Uint32")] uint first_instance);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUPrimitivesIndirect", ExactSpelling = true)]
    public static extern void DrawGPUPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset, [NativeTypeName("Uint32")] uint draw_count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect", ExactSpelling = true)]
    public static extern void DrawGPUIndexedPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset, [NativeTypeName("Uint32")] uint draw_count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPURenderPass", ExactSpelling = true)]
    public static extern void EndGPURenderPass(SDL_GPURenderPass* render_pass);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPUComputePass", ExactSpelling = true)]
    public static extern SDL_GPUComputePass* BeginGPUComputePass(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUStorageTextureReadWriteBinding *")] SDL_GPUStorageTextureReadWriteBinding* storage_texture_bindings, [NativeTypeName("Uint32")] uint num_storage_texture_bindings, [NativeTypeName("const SDL_GPUStorageBufferReadWriteBinding *")] SDL_GPUStorageBufferReadWriteBinding* storage_buffer_bindings, [NativeTypeName("Uint32")] uint num_storage_buffer_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputePipeline", ExactSpelling = true)]
    public static extern void BindGPUComputePipeline(SDL_GPUComputePass* compute_pass, SDL_GPUComputePipeline* compute_pipeline);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeSamplers", ExactSpelling = true)]
    public static extern void BindGPUComputeSamplers(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeStorageTextures", ExactSpelling = true)]
    public static extern void BindGPUComputeStorageTextures(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeStorageBuffers", ExactSpelling = true)]
    public static extern void BindGPUComputeStorageBuffers(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DispatchGPUCompute", ExactSpelling = true)]
    public static extern void DispatchGPUCompute(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint groupcount_x, [NativeTypeName("Uint32")] uint groupcount_y, [NativeTypeName("Uint32")] uint groupcount_z);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DispatchGPUComputeIndirect", ExactSpelling = true)]
    public static extern void DispatchGPUComputeIndirect(SDL_GPUComputePass* compute_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPUComputePass", ExactSpelling = true)]
    public static extern void EndGPUComputePass(SDL_GPUComputePass* compute_pass);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapGPUTransferBuffer", ExactSpelling = true)]
    public static extern void* MapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer, [NativeTypeName("_Bool")] byte cycle);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnmapGPUTransferBuffer", ExactSpelling = true)]
    public static extern void UnmapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPUCopyPass", ExactSpelling = true)]
    public static extern SDL_GPUCopyPass* BeginGPUCopyPass(SDL_GPUCommandBuffer* command_buffer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UploadToGPUTexture", ExactSpelling = true)]
    public static extern void UploadToGPUTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureTransferInfo *")] SDL_GPUTextureTransferInfo* source, [NativeTypeName("const SDL_GPUTextureRegion *")] SDL_GPUTextureRegion* destination, [NativeTypeName("_Bool")] byte cycle);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UploadToGPUBuffer", ExactSpelling = true)]
    public static extern void UploadToGPUBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTransferBufferLocation *")] SDL_GPUTransferBufferLocation* source, [NativeTypeName("const SDL_GPUBufferRegion *")] SDL_GPUBufferRegion* destination, [NativeTypeName("_Bool")] byte cycle);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyGPUTextureToTexture", ExactSpelling = true)]
    public static extern void CopyGPUTextureToTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureLocation *")] SDL_GPUTextureLocation* source, [NativeTypeName("const SDL_GPUTextureLocation *")] SDL_GPUTextureLocation* destination, [NativeTypeName("Uint32")] uint w, [NativeTypeName("Uint32")] uint h, [NativeTypeName("Uint32")] uint d, [NativeTypeName("_Bool")] byte cycle);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyGPUBufferToBuffer", ExactSpelling = true)]
    public static extern void CopyGPUBufferToBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUBufferLocation *")] SDL_GPUBufferLocation* source, [NativeTypeName("const SDL_GPUBufferLocation *")] SDL_GPUBufferLocation* destination, [NativeTypeName("Uint32")] uint size, [NativeTypeName("_Bool")] byte cycle);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DownloadFromGPUTexture", ExactSpelling = true)]
    public static extern void DownloadFromGPUTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureRegion *")] SDL_GPUTextureRegion* source, [NativeTypeName("const SDL_GPUTextureTransferInfo *")] SDL_GPUTextureTransferInfo* destination);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DownloadFromGPUBuffer", ExactSpelling = true)]
    public static extern void DownloadFromGPUBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUBufferRegion *")] SDL_GPUBufferRegion* source, [NativeTypeName("const SDL_GPUTransferBufferLocation *")] SDL_GPUTransferBufferLocation* destination);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPUCopyPass", ExactSpelling = true)]
    public static extern void EndGPUCopyPass(SDL_GPUCopyPass* copy_pass);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GenerateMipmapsForGPUTexture", ExactSpelling = true)]
    public static extern void GenerateMipmapsForGPUTexture(SDL_GPUCommandBuffer* command_buffer, SDL_GPUTexture* texture);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitGPUTexture", ExactSpelling = true)]
    public static extern void BlitGPUTexture(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUBlitInfo *")] SDL_GPUBlitInfo* info);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WindowSupportsGPUSwapchainComposition(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowSupportsGPUPresentMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WindowSupportsGPUPresentMode(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUPresentMode present_mode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClaimWindowForGPUDevice", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ClaimWindowForGPUDevice(SDL_GPUDevice* device, SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseWindowFromGPUDevice", ExactSpelling = true)]
    public static extern void ReleaseWindowFromGPUDevice(SDL_GPUDevice* device, SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUSwapchainParameters", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetGPUSwapchainParameters(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition, SDL_GPUPresentMode present_mode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUAllowedFramesInFlight", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetGPUAllowedFramesInFlight(SDL_GPUDevice* device, [NativeTypeName("Uint32")] uint allowed_frames_in_flight);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUSwapchainTextureFormat", ExactSpelling = true)]
    public static extern SDL_GPUTextureFormat GetGPUSwapchainTextureFormat(SDL_GPUDevice* device, SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireGPUSwapchainTexture", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte AcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture, [NativeTypeName("Uint32 *")] uint* swapchain_texture_width, [NativeTypeName("Uint32 *")] uint* swapchain_texture_height);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUSwapchain", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitForGPUSwapchain(SDL_GPUDevice* device, SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitAndAcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture, [NativeTypeName("Uint32 *")] uint* swapchain_texture_width, [NativeTypeName("Uint32 *")] uint* swapchain_texture_height);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SubmitGPUCommandBuffer", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SubmitGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence", ExactSpelling = true)]
    public static extern SDL_GPUFence* SubmitGPUCommandBufferAndAcquireFence(SDL_GPUCommandBuffer* command_buffer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CancelGPUCommandBuffer", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CancelGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUIdle", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitForGPUIdle(SDL_GPUDevice* device);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUFences", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitForGPUFences(SDL_GPUDevice* device, [NativeTypeName("_Bool")] byte wait_all, [NativeTypeName("SDL_GPUFence *const *")] SDL_GPUFence** fences, [NativeTypeName("Uint32")] uint num_fences);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QueryGPUFence", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte QueryGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUFence", ExactSpelling = true)]
    public static extern void ReleaseGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureFormatTexelBlockSize", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GPUTextureFormatTexelBlockSize(SDL_GPUTextureFormat format);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureSupportsFormat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GPUTextureSupportsFormat(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUTextureType type, [NativeTypeName("SDL_GPUTextureUsageFlags")] uint usage);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureSupportsSampleCount", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GPUTextureSupportsSampleCount(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUSampleCount sample_count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CalculateGPUTextureFormatSize", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint CalculateGPUTextureFormatSize(SDL_GPUTextureFormat format, [NativeTypeName("Uint32")] uint width, [NativeTypeName("Uint32")] uint height, [NativeTypeName("Uint32")] uint depth_or_layer_count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GUIDToString", ExactSpelling = true)]
    public static extern void GUIDToString(SDL_GUID guid, [NativeTypeName("char *")] byte* pszGUID, int cbGUID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StringToGUID", ExactSpelling = true)]
    public static extern SDL_GUID StringToGUID([NativeTypeName("const char *")] byte* pchGUID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHaptics", ExactSpelling = true)]
    [return: NativeTypeName("SDL_HapticID *")]
    public static extern uint* GetHaptics(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticNameForID", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetHapticNameForID([NativeTypeName("SDL_HapticID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHaptic", ExactSpelling = true)]
    public static extern SDL_Haptic* OpenHaptic([NativeTypeName("SDL_HapticID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticFromID", ExactSpelling = true)]
    public static extern SDL_Haptic* GetHapticFromID([NativeTypeName("SDL_HapticID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticID", ExactSpelling = true)]
    [return: NativeTypeName("SDL_HapticID")]
    public static extern uint GetHapticID(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetHapticName(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMouseHaptic", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsMouseHaptic();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHapticFromMouse", ExactSpelling = true)]
    public static extern SDL_Haptic* OpenHapticFromMouse();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickHaptic", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsJoystickHaptic(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHapticFromJoystick", ExactSpelling = true)]
    public static extern SDL_Haptic* OpenHapticFromJoystick(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseHaptic", ExactSpelling = true)]
    public static extern void CloseHaptic(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMaxHapticEffects", ExactSpelling = true)]
    public static extern int GetMaxHapticEffects(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMaxHapticEffectsPlaying", ExactSpelling = true)]
    public static extern int GetMaxHapticEffectsPlaying(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticFeatures", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetHapticFeatures(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumHapticAxes", ExactSpelling = true)]
    public static extern int GetNumHapticAxes(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticEffectSupported", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HapticEffectSupported(SDL_Haptic* haptic, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* effect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateHapticEffect", ExactSpelling = true)]
    public static extern int CreateHapticEffect(SDL_Haptic* haptic, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* effect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateHapticEffect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte UpdateHapticEffect(SDL_Haptic* haptic, int effect, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* data);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunHapticEffect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RunHapticEffect(SDL_Haptic* haptic, int effect, [NativeTypeName("Uint32")] uint iterations);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticEffect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte StopHapticEffect(SDL_Haptic* haptic, int effect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyHapticEffect", ExactSpelling = true)]
    public static extern void DestroyHapticEffect(SDL_Haptic* haptic, int effect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticEffectStatus", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetHapticEffectStatus(SDL_Haptic* haptic, int effect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHapticGain", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetHapticGain(SDL_Haptic* haptic, int gain);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHapticAutocenter", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetHapticAutocenter(SDL_Haptic* haptic, int autocenter);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseHaptic", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PauseHaptic(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeHaptic", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ResumeHaptic(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticEffects", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte StopHapticEffects(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRumbleSupported", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HapticRumbleSupported(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitHapticRumble", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte InitHapticRumble(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PlayHapticRumble", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PlayHapticRumble(SDL_Haptic* haptic, float strength, [NativeTypeName("Uint32")] uint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticRumble", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte StopHapticRumble(SDL_Haptic* haptic);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_init", ExactSpelling = true)]
    public static extern int hid_init();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_exit", ExactSpelling = true)]
    public static extern int hid_exit();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_device_change_count", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint hid_device_change_count();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_enumerate", ExactSpelling = true)]
    public static extern SDL_hid_device_info* hid_enumerate([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_free_enumeration", ExactSpelling = true)]
    public static extern void hid_free_enumeration(SDL_hid_device_info* devs);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_open", ExactSpelling = true)]
    public static extern SDL_hid_device* hid_open([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id, [NativeTypeName("const wchar_t *")] ushort* serial_number);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_open_path", ExactSpelling = true)]
    public static extern SDL_hid_device* hid_open_path([NativeTypeName("const char *")] byte* path);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_write", ExactSpelling = true)]
    public static extern int hid_write(SDL_hid_device* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_read_timeout", ExactSpelling = true)]
    public static extern int hid_read_timeout(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length, int milliseconds);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_read", ExactSpelling = true)]
    public static extern int hid_read(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_set_nonblocking", ExactSpelling = true)]
    public static extern int hid_set_nonblocking(SDL_hid_device* dev, int nonblock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_send_feature_report", ExactSpelling = true)]
    public static extern int hid_send_feature_report(SDL_hid_device* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_feature_report", ExactSpelling = true)]
    public static extern int hid_get_feature_report(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_input_report", ExactSpelling = true)]
    public static extern int hid_get_input_report(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_close", ExactSpelling = true)]
    public static extern int hid_close(SDL_hid_device* dev);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_manufacturer_string", ExactSpelling = true)]
    public static extern int hid_get_manufacturer_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] ushort* @string, [NativeTypeName("size_t")] nuint maxlen);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_product_string", ExactSpelling = true)]
    public static extern int hid_get_product_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] ushort* @string, [NativeTypeName("size_t")] nuint maxlen);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_serial_number_string", ExactSpelling = true)]
    public static extern int hid_get_serial_number_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] ushort* @string, [NativeTypeName("size_t")] nuint maxlen);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_indexed_string", ExactSpelling = true)]
    public static extern int hid_get_indexed_string(SDL_hid_device* dev, int string_index, [NativeTypeName("wchar_t *")] ushort* @string, [NativeTypeName("size_t")] nuint maxlen);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_device_info", ExactSpelling = true)]
    public static extern SDL_hid_device_info* hid_get_device_info(SDL_hid_device* dev);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_report_descriptor", ExactSpelling = true)]
    public static extern int hid_get_report_descriptor(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* buf, [NativeTypeName("size_t")] nuint buf_size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_ble_scan", ExactSpelling = true)]
    public static extern void hid_ble_scan([NativeTypeName("_Bool")] byte active);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHintWithPriority", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetHintWithPriority([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value, SDL_HintPriority priority);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHint", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetHint([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetHint", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ResetHint([NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetHints", ExactSpelling = true)]
    public static extern void ResetHints();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHint", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetHint([NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHintBoolean", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetHintBoolean([NativeTypeName("const char *")] byte* name, [NativeTypeName("_Bool")] byte default_value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddHintCallback", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte AddHintCallback([NativeTypeName("const char *")] byte* name, [NativeTypeName("SDL_HintCallback")] delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveHintCallback", ExactSpelling = true)]
    public static extern void RemoveHintCallback([NativeTypeName("const char *")] byte* name, [NativeTypeName("SDL_HintCallback")] delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Init", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte Init([NativeTypeName("SDL_InitFlags")] uint flags);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitSubSystem", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte InitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QuitSubSystem", ExactSpelling = true)]
    public static extern void QuitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WasInit", ExactSpelling = true)]
    [return: NativeTypeName("SDL_InitFlags")]
    public static extern uint WasInit([NativeTypeName("SDL_InitFlags")] uint flags);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Quit", ExactSpelling = true)]
    public static extern void Quit();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMainThread", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsMainThread();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunOnMainThread", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RunOnMainThread([NativeTypeName("SDL_MainThreadCallback")] delegate* unmanaged[Cdecl]<void*, void> callback, void* userdata, [NativeTypeName("_Bool")] byte wait_complete);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadata", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAppMetadata([NativeTypeName("const char *")] byte* appname, [NativeTypeName("const char *")] byte* appversion, [NativeTypeName("const char *")] byte* appidentifier);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadataProperty", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetAppMetadataProperty([NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAppMetadataProperty", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetAppMetadataProperty([NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromFile", ExactSpelling = true)]
    public static extern SDL_IOStream* IOFromFile([NativeTypeName("const char *")] byte* file, [NativeTypeName("const char *")] byte* mode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromMem", ExactSpelling = true)]
    public static extern SDL_IOStream* IOFromMem(void* mem, [NativeTypeName("size_t")] nuint size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromConstMem", ExactSpelling = true)]
    public static extern SDL_IOStream* IOFromConstMem([NativeTypeName("const void *")] void* mem, [NativeTypeName("size_t")] nuint size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromDynamicMem", ExactSpelling = true)]
    public static extern SDL_IOStream* IOFromDynamicMem();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenIO", ExactSpelling = true)]
    public static extern SDL_IOStream* OpenIO([NativeTypeName("const SDL_IOStreamInterface *")] SDL_IOStreamInterface* iface, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseIO", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CloseIO(SDL_IOStream* context);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetIOProperties(SDL_IOStream* context);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOStatus", ExactSpelling = true)]
    public static extern SDL_IOStatus GetIOStatus(SDL_IOStream* context);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOSize", ExactSpelling = true)]
    [return: NativeTypeName("Sint64")]
    public static extern long GetIOSize(SDL_IOStream* context);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SeekIO", ExactSpelling = true)]
    [return: NativeTypeName("Sint64")]
    public static extern long SeekIO(SDL_IOStream* context, [NativeTypeName("Sint64")] long offset, SDL_IOWhence whence);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TellIO", ExactSpelling = true)]
    [return: NativeTypeName("Sint64")]
    public static extern long TellIO(SDL_IOStream* context);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadIO", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint ReadIO(SDL_IOStream* context, void* ptr, [NativeTypeName("size_t")] nuint size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteIO", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint WriteIO(SDL_IOStream* context, [NativeTypeName("const void *")] void* ptr, [NativeTypeName("size_t")] nuint size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOprintf", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint IOprintf(SDL_IOStream* context, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOvprintf", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint IOvprintf(SDL_IOStream* context, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushIO", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte FlushIO(SDL_IOStream* context);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile_IO", ExactSpelling = true)]
    public static extern void* LoadFile_IO(SDL_IOStream* src, [NativeTypeName("size_t *")] nuint* datasize, [NativeTypeName("_Bool")] byte closeio);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile", ExactSpelling = true)]
    public static extern void* LoadFile([NativeTypeName("const char *")] byte* file, [NativeTypeName("size_t *")] nuint* datasize);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveFile_IO", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SaveFile_IO(SDL_IOStream* src, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint datasize, [NativeTypeName("_Bool")] byte closeio);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveFile", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SaveFile([NativeTypeName("const char *")] byte* file, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint datasize);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU8", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadU8(SDL_IOStream* src, [NativeTypeName("Uint8 *")] byte* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS8", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadS8(SDL_IOStream* src, [NativeTypeName("Sint8 *")] sbyte* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU16LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadU16LE(SDL_IOStream* src, [NativeTypeName("Uint16 *")] ushort* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS16LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadS16LE(SDL_IOStream* src, [NativeTypeName("Sint16 *")] short* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU16BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadU16BE(SDL_IOStream* src, [NativeTypeName("Uint16 *")] ushort* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS16BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadS16BE(SDL_IOStream* src, [NativeTypeName("Sint16 *")] short* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU32LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadU32LE(SDL_IOStream* src, [NativeTypeName("Uint32 *")] uint* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS32LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadS32LE(SDL_IOStream* src, [NativeTypeName("Sint32 *")] int* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU32BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadU32BE(SDL_IOStream* src, [NativeTypeName("Uint32 *")] uint* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS32BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadS32BE(SDL_IOStream* src, [NativeTypeName("Sint32 *")] int* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU64LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadU64LE(SDL_IOStream* src, [NativeTypeName("Uint64 *")] ulong* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS64LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadS64LE(SDL_IOStream* src, [NativeTypeName("Sint64 *")] long* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU64BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadU64BE(SDL_IOStream* src, [NativeTypeName("Uint64 *")] ulong* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS64BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadS64BE(SDL_IOStream* src, [NativeTypeName("Sint64 *")] long* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU8", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteU8(SDL_IOStream* dst, [NativeTypeName("Uint8")] byte value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS8", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteS8(SDL_IOStream* dst, [NativeTypeName("Sint8")] sbyte value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU16LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteU16LE(SDL_IOStream* dst, [NativeTypeName("Uint16")] ushort value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS16LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteS16LE(SDL_IOStream* dst, [NativeTypeName("Sint16")] short value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU16BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteU16BE(SDL_IOStream* dst, [NativeTypeName("Uint16")] ushort value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS16BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteS16BE(SDL_IOStream* dst, [NativeTypeName("Sint16")] short value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU32LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteU32LE(SDL_IOStream* dst, [NativeTypeName("Uint32")] uint value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS32LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteS32LE(SDL_IOStream* dst, [NativeTypeName("Sint32")] int value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU32BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteU32BE(SDL_IOStream* dst, [NativeTypeName("Uint32")] uint value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS32BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteS32BE(SDL_IOStream* dst, [NativeTypeName("Sint32")] int value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU64LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteU64LE(SDL_IOStream* dst, [NativeTypeName("Uint64")] ulong value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS64LE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteS64LE(SDL_IOStream* dst, [NativeTypeName("Sint64")] long value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU64BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteU64BE(SDL_IOStream* dst, [NativeTypeName("Uint64")] ulong value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS64BE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteS64BE(SDL_IOStream* dst, [NativeTypeName("Sint64")] long value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockJoysticks", ExactSpelling = true)]
    public static extern void LockJoysticks();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockJoysticks", ExactSpelling = true)]
    public static extern void UnlockJoysticks();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasJoystick", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasJoystick();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoysticks", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID *")]
    public static extern uint* GetJoysticks(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickNameForID", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetJoystickNameForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPathForID", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetJoystickPathForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndexForID", ExactSpelling = true)]
    public static extern int GetJoystickPlayerIndexForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDForID", ExactSpelling = true)]
    public static extern SDL_GUID GetJoystickGUIDForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendorForID", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickVendorForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductForID", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickProductForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersionForID", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickProductVersionForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickTypeForID", ExactSpelling = true)]
    public static extern SDL_JoystickType GetJoystickTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenJoystick", ExactSpelling = true)]
    public static extern SDL_Joystick* OpenJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromID", ExactSpelling = true)]
    public static extern SDL_Joystick* GetJoystickFromID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromPlayerIndex", ExactSpelling = true)]
    public static extern SDL_Joystick* GetJoystickFromPlayerIndex(int player_index);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AttachVirtualJoystick", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint AttachVirtualJoystick([NativeTypeName("const SDL_VirtualJoystickDesc *")] SDL_VirtualJoystickDesc* desc);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachVirtualJoystick", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte DetachVirtualJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickVirtual", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsJoystickVirtual([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualAxis", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16")] short value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualBall", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, [NativeTypeName("Sint16")] short xrel, [NativeTypeName("Sint16")] short yrel);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualButton", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetJoystickVirtualButton(SDL_Joystick* joystick, int button, [NativeTypeName("_Bool")] byte down);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualHat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, [NativeTypeName("Uint8")] byte value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualTouchpad", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, [NativeTypeName("_Bool")] byte down, float x, float y, float pressure);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickVirtualSensorData", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, [NativeTypeName("Uint64")] ulong sensor_timestamp, [NativeTypeName("const float *")] float* data, int num_values);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetJoystickProperties(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetJoystickName(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPath", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetJoystickPath(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndex", ExactSpelling = true)]
    public static extern int GetJoystickPlayerIndex(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickPlayerIndex", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUID", ExactSpelling = true)]
    public static extern SDL_GUID GetJoystickGUID(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendor", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickVendor(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProduct", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickProduct(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersion", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickProductVersion(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFirmwareVersion", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickFirmwareVersion(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSerial", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetJoystickSerial(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickType", ExactSpelling = true)]
    public static extern SDL_JoystickType GetJoystickType(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDInfo", ExactSpelling = true)]
    public static extern void GetJoystickGUIDInfo(SDL_GUID guid, [NativeTypeName("Uint16 *")] ushort* vendor, [NativeTypeName("Uint16 *")] ushort* product, [NativeTypeName("Uint16 *")] ushort* version, [NativeTypeName("Uint16 *")] ushort* crc16);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickConnected", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte JoystickConnected(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickID", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint GetJoystickID(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickAxes", ExactSpelling = true)]
    public static extern int GetNumJoystickAxes(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickBalls", ExactSpelling = true)]
    public static extern int GetNumJoystickBalls(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickHats", ExactSpelling = true)]
    public static extern int GetNumJoystickHats(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickButtons", ExactSpelling = true)]
    public static extern int GetNumJoystickButtons(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickEventsEnabled", ExactSpelling = true)]
    public static extern void SetJoystickEventsEnabled([NativeTypeName("_Bool")] byte enabled);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickEventsEnabled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte JoystickEventsEnabled();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateJoysticks", ExactSpelling = true)]
    public static extern void UpdateJoysticks();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxis", ExactSpelling = true)]
    [return: NativeTypeName("Sint16")]
    public static extern short GetJoystickAxis(SDL_Joystick* joystick, int axis);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxisInitialState", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16 *")] short* state);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickBall", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickHat", ExactSpelling = true)]
    [return: NativeTypeName("Uint8")]
    public static extern byte GetJoystickHat(SDL_Joystick* joystick, int hat);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickButton", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetJoystickButton(SDL_Joystick* joystick, int button);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystick", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RumbleJoystick(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystickTriggers", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RumbleJoystickTriggers(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickLED", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetJoystickLED(SDL_Joystick* joystick, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickEffect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SendJoystickEffect(SDL_Joystick* joystick, [NativeTypeName("const void *")] void* data, int size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseJoystick", ExactSpelling = true)]
    public static extern void CloseJoystick(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickConnectionState", ExactSpelling = true)]
    public static extern SDL_JoystickConnectionState GetJoystickConnectionState(SDL_Joystick* joystick);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPowerInfo", ExactSpelling = true)]
    public static extern SDL_PowerState GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasKeyboard", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasKeyboard();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboards", ExactSpelling = true)]
    [return: NativeTypeName("SDL_KeyboardID *")]
    public static extern uint* GetKeyboards(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardNameForID", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetKeyboardNameForID([NativeTypeName("SDL_KeyboardID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardFocus", ExactSpelling = true)]
    public static extern SDL_Window* GetKeyboardFocus();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardState", ExactSpelling = true)]
    [return: NativeTypeName("const _Bool *")]
    public static extern bool* GetKeyboardState(int* numkeys);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetKeyboard", ExactSpelling = true)]
    public static extern void ResetKeyboard();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetModState", ExactSpelling = true)]
    [return: NativeTypeName("SDL_Keymod")]
    public static extern ushort GetModState();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetModState", ExactSpelling = true)]
    public static extern void SetModState([NativeTypeName("SDL_Keymod")] ushort modstate);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromScancode", ExactSpelling = true)]
    [return: NativeTypeName("SDL_Keycode")]
    public static extern uint GetKeyFromScancode(SDL_Scancode scancode, [NativeTypeName("SDL_Keymod")] ushort modstate, [NativeTypeName("_Bool")] byte key_event);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromKey", ExactSpelling = true)]
    public static extern SDL_Scancode GetScancodeFromKey([NativeTypeName("SDL_Keycode")] uint key, [NativeTypeName("SDL_Keymod *")] ushort* modstate);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetScancodeName", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetScancodeName(SDL_Scancode scancode, [NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetScancodeName(SDL_Scancode scancode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromName", ExactSpelling = true)]
    public static extern SDL_Scancode GetScancodeFromName([NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetKeyName([NativeTypeName("SDL_Keycode")] uint key);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromName", ExactSpelling = true)]
    [return: NativeTypeName("SDL_Keycode")]
    public static extern uint GetKeyFromName([NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInput", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte StartTextInput(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInputWithProperties", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte StartTextInputWithProperties(SDL_Window* window, [NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TextInputActive", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte TextInputActive(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopTextInput", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte StopTextInput(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearComposition", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ClearComposition(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextInputArea", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetTextInputArea(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, int cursor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextInputArea", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTextInputArea(SDL_Window* window, SDL_Rect* rect, int* cursor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasScreenKeyboardSupport", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasScreenKeyboardSupport();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScreenKeyboardShown", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ScreenKeyboardShown(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadObject", ExactSpelling = true)]
    public static extern SDL_SharedObject* LoadObject([NativeTypeName("const char *")] byte* sofile);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFunction", ExactSpelling = true)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged[Cdecl]<void> LoadFunction(SDL_SharedObject* handle, [NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnloadObject", ExactSpelling = true)]
    public static extern void UnloadObject(SDL_SharedObject* handle);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPreferredLocales", ExactSpelling = true)]
    public static extern SDL_Locale** GetPreferredLocales(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriorities", ExactSpelling = true)]
    public static extern void SetLogPriorities(SDL_LogPriority priority);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriority", ExactSpelling = true)]
    public static extern void SetLogPriority(int category, SDL_LogPriority priority);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetLogPriority", ExactSpelling = true)]
    public static extern SDL_LogPriority GetLogPriority(int category);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetLogPriorities", ExactSpelling = true)]
    public static extern void ResetLogPriorities();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogPriorityPrefix", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetLogPriorityPrefix(SDL_LogPriority priority, [NativeTypeName("const char *")] byte* prefix);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Log", ExactSpelling = true)]
    public static extern void Log([NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogTrace", ExactSpelling = true)]
    public static extern void LogTrace(int category, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogVerbose", ExactSpelling = true)]
    public static extern void LogVerbose(int category, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogDebug", ExactSpelling = true)]
    public static extern void LogDebug(int category, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogInfo", ExactSpelling = true)]
    public static extern void LogInfo(int category, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogWarn", ExactSpelling = true)]
    public static extern void LogWarn(int category, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogError", ExactSpelling = true)]
    public static extern void LogError(int category, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogCritical", ExactSpelling = true)]
    public static extern void LogCritical(int category, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogMessage", ExactSpelling = true)]
    public static extern void LogMessage(int category, SDL_LogPriority priority, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LogMessageV", ExactSpelling = true)]
    public static extern void LogMessageV(int category, SDL_LogPriority priority, [NativeTypeName("const char *")] byte* fmt, [NativeTypeName("va_list")] byte* ap);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultLogOutputFunction", ExactSpelling = true)]
    [return: NativeTypeName("SDL_LogOutputFunction")]
    public static extern delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, byte*, void> GetDefaultLogOutputFunction();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetLogOutputFunction", ExactSpelling = true)]
    public static extern void GetLogOutputFunction([NativeTypeName("SDL_LogOutputFunction *")] delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, byte*, void>* callback, void** userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetLogOutputFunction", ExactSpelling = true)]
    public static extern void SetLogOutputFunction([NativeTypeName("SDL_LogOutputFunction")] delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, byte*, void> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowMessageBox", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ShowMessageBox([NativeTypeName("const SDL_MessageBoxData *")] SDL_MessageBoxData* messageboxdata, int* buttonid);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSimpleMessageBox", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ShowSimpleMessageBox([NativeTypeName("SDL_MessageBoxFlags")] uint flags, [NativeTypeName("const char *")] byte* title, [NativeTypeName("const char *")] byte* message, SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_CreateView", ExactSpelling = true)]
    [return: NativeTypeName("SDL_MetalView")]
    public static extern void* Metal_CreateView(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_DestroyView", ExactSpelling = true)]
    public static extern void Metal_DestroyView([NativeTypeName("SDL_MetalView")] void* view);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Metal_GetLayer", ExactSpelling = true)]
    public static extern void* Metal_GetLayer([NativeTypeName("SDL_MetalView")] void* view);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenURL", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte OpenURL([NativeTypeName("const char *")] byte* url);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasMouse", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasMouse();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMice", ExactSpelling = true)]
    [return: NativeTypeName("SDL_MouseID *")]
    public static extern uint* GetMice(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseNameForID", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetMouseNameForID([NativeTypeName("SDL_MouseID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseFocus", ExactSpelling = true)]
    public static extern SDL_Window* GetMouseFocus();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMouseState", ExactSpelling = true)]
    [return: NativeTypeName("SDL_MouseButtonFlags")]
    public static extern uint GetMouseState(float* x, float* y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGlobalMouseState", ExactSpelling = true)]
    [return: NativeTypeName("SDL_MouseButtonFlags")]
    public static extern uint GetGlobalMouseState(float* x, float* y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRelativeMouseState", ExactSpelling = true)]
    [return: NativeTypeName("SDL_MouseButtonFlags")]
    public static extern uint GetRelativeMouseState(float* x, float* y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseInWindow", ExactSpelling = true)]
    public static extern void WarpMouseInWindow(SDL_Window* window, float x, float y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WarpMouseGlobal", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WarpMouseGlobal(float x, float y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowRelativeMouseMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowRelativeMouseMode(SDL_Window* window, [NativeTypeName("_Bool")] byte enabled);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowRelativeMouseMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowRelativeMouseMode(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CaptureMouse", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CaptureMouse([NativeTypeName("_Bool")] byte enabled);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateCursor", ExactSpelling = true)]
    public static extern SDL_Cursor* CreateCursor([NativeTypeName("const Uint8 *")] byte* data, [NativeTypeName("const Uint8 *")] byte* mask, int w, int h, int hot_x, int hot_y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateColorCursor", ExactSpelling = true)]
    public static extern SDL_Cursor* CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSystemCursor", ExactSpelling = true)]
    public static extern SDL_Cursor* CreateSystemCursor(SDL_SystemCursor id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCursor", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetCursor(SDL_Cursor* cursor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCursor", ExactSpelling = true)]
    public static extern SDL_Cursor* GetCursor();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultCursor", ExactSpelling = true)]
    public static extern SDL_Cursor* GetDefaultCursor();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyCursor", ExactSpelling = true)]
    public static extern void DestroyCursor(SDL_Cursor* cursor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowCursor", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ShowCursor();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideCursor", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HideCursor();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CursorVisible", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CursorVisible();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateMutex", ExactSpelling = true)]
    public static extern SDL_Mutex* CreateMutex();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockMutex", ExactSpelling = true)]
    public static extern void LockMutex(SDL_Mutex* mutex);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockMutex", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte TryLockMutex(SDL_Mutex* mutex);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockMutex", ExactSpelling = true)]
    public static extern void UnlockMutex(SDL_Mutex* mutex);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyMutex", ExactSpelling = true)]
    public static extern void DestroyMutex(SDL_Mutex* mutex);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRWLock", ExactSpelling = true)]
    public static extern SDL_RWLock* CreateRWLock();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockRWLockForReading", ExactSpelling = true)]
    public static extern void LockRWLockForReading(SDL_RWLock* rwlock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockRWLockForWriting", ExactSpelling = true)]
    public static extern void LockRWLockForWriting(SDL_RWLock* rwlock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockRWLockForReading", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte TryLockRWLockForReading(SDL_RWLock* rwlock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockRWLockForWriting", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte TryLockRWLockForWriting(SDL_RWLock* rwlock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockRWLock", ExactSpelling = true)]
    public static extern void UnlockRWLock(SDL_RWLock* rwlock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyRWLock", ExactSpelling = true)]
    public static extern void DestroyRWLock(SDL_RWLock* rwlock);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSemaphore", ExactSpelling = true)]
    public static extern SDL_Semaphore* CreateSemaphore([NativeTypeName("Uint32")] uint initial_value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroySemaphore", ExactSpelling = true)]
    public static extern void DestroySemaphore(SDL_Semaphore* sem);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitSemaphore", ExactSpelling = true)]
    public static extern void WaitSemaphore(SDL_Semaphore* sem);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryWaitSemaphore", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte TryWaitSemaphore(SDL_Semaphore* sem);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitSemaphoreTimeout", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitSemaphoreTimeout(SDL_Semaphore* sem, [NativeTypeName("Sint32")] int timeoutMS);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalSemaphore", ExactSpelling = true)]
    public static extern void SignalSemaphore(SDL_Semaphore* sem);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSemaphoreValue", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetSemaphoreValue(SDL_Semaphore* sem);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateCondition", ExactSpelling = true)]
    public static extern SDL_Condition* CreateCondition();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyCondition", ExactSpelling = true)]
    public static extern void DestroyCondition(SDL_Condition* cond);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalCondition", ExactSpelling = true)]
    public static extern void SignalCondition(SDL_Condition* cond);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BroadcastCondition", ExactSpelling = true)]
    public static extern void BroadcastCondition(SDL_Condition* cond);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitCondition", ExactSpelling = true)]
    public static extern void WaitCondition(SDL_Condition* cond, SDL_Mutex* mutex);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitConditionTimeout", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitConditionTimeout(SDL_Condition* cond, SDL_Mutex* mutex, [NativeTypeName("Sint32")] int timeoutMS);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShouldInit", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ShouldInit(SDL_InitState* state);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShouldQuit", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ShouldQuit(SDL_InitState* state);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetInitialized", ExactSpelling = true)]
    public static extern void SetInitialized(SDL_InitState* state, [NativeTypeName("_Bool")] byte initialized);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetPixelFormatName(SDL_PixelFormat format);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMasksForPixelFormat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetMasksForPixelFormat(SDL_PixelFormat format, int* bpp, [NativeTypeName("Uint32 *")] uint* Rmask, [NativeTypeName("Uint32 *")] uint* Gmask, [NativeTypeName("Uint32 *")] uint* Bmask, [NativeTypeName("Uint32 *")] uint* Amask);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatForMasks", ExactSpelling = true)]
    public static extern SDL_PixelFormat GetPixelFormatForMasks(int bpp, [NativeTypeName("Uint32")] uint Rmask, [NativeTypeName("Uint32")] uint Gmask, [NativeTypeName("Uint32")] uint Bmask, [NativeTypeName("Uint32")] uint Amask);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPixelFormatDetails", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_PixelFormatDetails *")]
    public static extern SDL_PixelFormatDetails* GetPixelFormatDetails(SDL_PixelFormat format);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreatePalette", ExactSpelling = true)]
    public static extern SDL_Palette* CreatePalette(int ncolors);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPaletteColors", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetPaletteColors(SDL_Palette* palette, [NativeTypeName("const SDL_Color *")] SDL_Color* colors, int firstcolor, int ncolors);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyPalette", ExactSpelling = true)]
    public static extern void DestroyPalette(SDL_Palette* palette);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapRGB", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint MapRGB([NativeTypeName("const SDL_PixelFormatDetails *")] SDL_PixelFormatDetails* format, [NativeTypeName("const SDL_Palette *")] SDL_Palette* palette, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapRGBA", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint MapRGBA([NativeTypeName("const SDL_PixelFormatDetails *")] SDL_PixelFormatDetails* format, [NativeTypeName("const SDL_Palette *")] SDL_Palette* palette, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRGB", ExactSpelling = true)]
    public static extern void GetRGB([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormatDetails *")] SDL_PixelFormatDetails* format, [NativeTypeName("const SDL_Palette *")] SDL_Palette* palette, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRGBA", ExactSpelling = true)]
    public static extern void GetRGBA([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormatDetails *")] SDL_PixelFormatDetails* format, [NativeTypeName("const SDL_Palette *")] SDL_Palette* palette, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPlatform", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetPlatform();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPowerInfo", ExactSpelling = true)]
    public static extern SDL_PowerState GetPowerInfo(int* seconds, int* percent);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProcess", ExactSpelling = true)]
    public static extern SDL_Process* CreateProcess([NativeTypeName("const char *const *")] byte** args, [NativeTypeName("_Bool")] byte pipe_stdio);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProcessWithProperties", ExactSpelling = true)]
    public static extern SDL_Process* CreateProcessWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetProcessProperties(SDL_Process* process);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadProcess", ExactSpelling = true)]
    public static extern void* ReadProcess(SDL_Process* process, [NativeTypeName("size_t *")] nuint* datasize, int* exitcode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessInput", ExactSpelling = true)]
    public static extern SDL_IOStream* GetProcessInput(SDL_Process* process);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessOutput", ExactSpelling = true)]
    public static extern SDL_IOStream* GetProcessOutput(SDL_Process* process);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_KillProcess", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte KillProcess(SDL_Process* process, [NativeTypeName("_Bool")] byte force);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitProcess", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WaitProcess(SDL_Process* process, [NativeTypeName("_Bool")] byte block, int* exitcode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProcess", ExactSpelling = true)]
    public static extern void DestroyProcess(SDL_Process* process);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGlobalProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetGlobalProperties();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint CreateProperties();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyProperties", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CopyProperties([NativeTypeName("SDL_PropertiesID")] uint src, [NativeTypeName("SDL_PropertiesID")] uint dst);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockProperties", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte LockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockProperties", ExactSpelling = true)]
    public static extern void UnlockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerPropertyWithCleanup", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetPointerPropertyWithCleanup([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, void* value, [NativeTypeName("SDL_CleanupPropertyCallback")] delegate* unmanaged[Cdecl]<void*, void*, void> cleanup, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerProperty", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetPointerProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, void* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetStringProperty", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetStringProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("const char *")] byte* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetNumberProperty", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetNumberProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("Sint64")] long value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetFloatProperty", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetFloatProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, float value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetBooleanProperty", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetBooleanProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("_Bool")] byte value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasProperty", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

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
    public static extern byte GetBooleanProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name, [NativeTypeName("_Bool")] byte default_value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearProperty", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ClearProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateProperties", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte EnumerateProperties([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("SDL_EnumeratePropertiesCallback")] delegate* unmanaged[Cdecl]<void*, uint, byte*, void> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProperties", ExactSpelling = true)]
    public static extern void DestroyProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    public static void RectToFRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_FRect* frect)
    {
        frect->x = (float)(rect->x);
        frect->y = (float)(rect->y);
        frect->w = (float)(rect->w);
        frect->h = (float)(rect->h);
    }

    [return: NativeTypeName("_Bool")]
    public static bool PointInRect([NativeTypeName("const SDL_Point *")] SDL_Point* p, [NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
    {
        return (((p != null) && (r != null) && (p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? 1 : 0) != 0;
    }

    [return: NativeTypeName("_Bool")]
    public static bool RectEmpty([NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
    {
        return (((r == null) || (r->w <= 0) || (r->h <= 0)) ? 1 : 0) != 0;
    }

    [return: NativeTypeName("_Bool")]
    public static bool RectsEqual([NativeTypeName("const SDL_Rect *")] SDL_Rect* a, [NativeTypeName("const SDL_Rect *")] SDL_Rect* b)
    {
        return (((a != null) && (b != null) && (a->x == b->x) && (a->y == b->y) && (a->w == b->w) && (a->h == b->h)) ? 1 : 0) != 0;
    }

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRectIntersection", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasRectIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectIntersection", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRectIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectUnion", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRectUnion([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectEnclosingPoints", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRectEnclosingPoints([NativeTypeName("const SDL_Point *")] SDL_Point* points, int count, [NativeTypeName("const SDL_Rect *")] SDL_Rect* clip, SDL_Rect* result);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectAndLineIntersection", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRectAndLineIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

    [return: NativeTypeName("_Bool")]
    public static bool PointInRectFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* p, [NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
    {
        return (((p != null) && (r != null) && (p->x >= r->x) && (p->x <= (r->x + r->w)) && (p->y >= r->y) && (p->y <= (r->y + r->h))) ? 1 : 0) != 0;
    }

    [return: NativeTypeName("_Bool")]
    public static bool RectEmptyFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
    {
        return (((r == null) || (r->w < 0.0f) || (r->h < 0.0f)) ? 1 : 0) != 0;
    }

    [return: NativeTypeName("_Bool")]
    public static bool RectsEqualEpsilon([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b, float epsilon)
    {
        return (((a != null) && (b != null) && ((a == b) || ((fabsf(a->x - b->x) <= epsilon) && (fabsf(a->y - b->y) <= epsilon) && (fabsf(a->w - b->w) <= epsilon) && (fabsf(a->h - b->h) <= epsilon)))) ? 1 : 0) != 0;
    }

    [return: NativeTypeName("_Bool")]
    public static bool RectsEqualFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b)
    {
        return RectsEqualEpsilon(a, b, 1.1920928955078125e-07F);
    }

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRectIntersectionFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HasRectIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectIntersectionFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRectIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectUnionFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRectUnionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectEnclosingPointsFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRectEnclosingPointsFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count, [NativeTypeName("const SDL_FRect *")] SDL_FRect* clip, SDL_FRect* result);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectAndLineIntersectionFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRectAndLineIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumRenderDrivers", ExactSpelling = true)]
    public static extern int GetNumRenderDrivers();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDriver", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetRenderDriver(int index);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowAndRenderer", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CreateWindowAndRenderer([NativeTypeName("const char *")] byte* title, int width, int height, [NativeTypeName("SDL_WindowFlags")] ulong window_flags, SDL_Window** window, SDL_Renderer** renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRenderer", ExactSpelling = true)]
    public static extern SDL_Renderer* CreateRenderer(SDL_Window* window, [NativeTypeName("const char *")] byte* name);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRendererWithProperties", ExactSpelling = true)]
    public static extern SDL_Renderer* CreateRendererWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSoftwareRenderer", ExactSpelling = true)]
    public static extern SDL_Renderer* CreateSoftwareRenderer(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderer", ExactSpelling = true)]
    public static extern SDL_Renderer* GetRenderer(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderWindow", ExactSpelling = true)]
    public static extern SDL_Window* GetRenderWindow(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetRendererName(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetRendererProperties(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderOutputSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentRenderOutputSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTexture", ExactSpelling = true)]
    public static extern SDL_Texture* CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int w, int h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureFromSurface", ExactSpelling = true)]
    public static extern SDL_Texture* CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureWithProperties", ExactSpelling = true)]
    public static extern SDL_Texture* CreateTextureWithProperties(SDL_Renderer* renderer, [NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetTextureProperties(SDL_Texture* texture);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererFromTexture", ExactSpelling = true)]
    public static extern SDL_Renderer* GetRendererFromTexture(SDL_Texture* texture);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTextureSize(SDL_Texture* texture, float* w, float* h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorMod", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorModFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorMod", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorModFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTextureColorModFloat(SDL_Texture* texture, float* r, float* g, float* b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaMod", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte alpha);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaModFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetTextureAlphaModFloat(SDL_Texture* texture, float alpha);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaMod", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* alpha);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaModFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureBlendMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetTextureBlendMode(SDL_Texture* texture, [NativeTypeName("SDL_BlendMode")] uint blendMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureBlendMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTextureBlendMode(SDL_Texture* texture, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureScaleMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureScaleMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateTexture", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte UpdateTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const void *")] void* pixels, int pitch);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateYUVTexture", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte UpdateYUVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* Uplane, int Upitch, [NativeTypeName("const Uint8 *")] byte* Vplane, int Vpitch);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateNVTexture", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte UpdateNVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* UVplane, int UVpitch);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTexture", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte LockTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, void** pixels, int* pitch);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTextureToSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte LockTextureToSurface(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_Surface** surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockTexture", ExactSpelling = true)]
    public static extern void UnlockTexture(SDL_Texture* texture);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderTarget", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderTarget", ExactSpelling = true)]
    public static extern SDL_Texture* GetRenderTarget(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderLogicalPresentation", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderLogicalPresentation", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderLogicalPresentation(SDL_Renderer* renderer, int* w, int* h, SDL_RendererLogicalPresentation* mode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderLogicalPresentationRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderLogicalPresentationRect(SDL_Renderer* renderer, SDL_FRect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCoordinatesFromWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, float* x, float* y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCoordinatesToWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* window_x, float* window_y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertEventToRenderCoordinates", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderViewport", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderViewport(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderViewport", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderViewportSet", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderViewportSet(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderSafeArea", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderSafeArea(SDL_Renderer* renderer, SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderClipRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderClipRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderClipRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClipEnabled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderClipEnabled(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderScale", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderScale", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColor", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColorFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColor", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColorFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderDrawColorFloat(SDL_Renderer* renderer, float* r, float* g, float* b, float* a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderColorScale", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderColorScale(SDL_Renderer* renderer, float scale);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderColorScale", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderColorScale(SDL_Renderer* renderer, float* scale);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawBlendMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderDrawBlendMode(SDL_Renderer* renderer, [NativeTypeName("SDL_BlendMode")] uint blendMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawBlendMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderDrawBlendMode(SDL_Renderer* renderer, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClear", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderClear(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPoint", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderPoint(SDL_Renderer* renderer, float x, float y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPoints", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderPoints(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLine", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLines", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderLines(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderRects", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderFillRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRects", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderFillRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureRotated", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, double angle, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* center, SDL_FlipMode flip);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureAffine", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderTextureAffine(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* origin, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* right, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* down);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureTiled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderTextureTiled(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture9Grid", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderTexture9Grid(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometry", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Vertex *")] SDL_Vertex* vertices, int num_vertices, [NativeTypeName("const int *")] int* indices, int num_indices);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometryRaw", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const float *")] float* xy, int xy_stride, [NativeTypeName("const SDL_FColor *")] SDL_FColor* color, int color_stride, [NativeTypeName("const float *")] float* uv, int uv_stride, int num_vertices, [NativeTypeName("const void *")] void* indices, int num_indices, int size_indices);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderReadPixels", ExactSpelling = true)]
    public static extern SDL_Surface* RenderReadPixels(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPresent", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderPresent(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyTexture", ExactSpelling = true)]
    public static extern void DestroyTexture(SDL_Texture* texture);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyRenderer", ExactSpelling = true)]
    public static extern void DestroyRenderer(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushRenderer", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte FlushRenderer(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderMetalLayer", ExactSpelling = true)]
    public static extern void* GetRenderMetalLayer(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderMetalCommandEncoder", ExactSpelling = true)]
    public static extern void* GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddVulkanRenderSemaphores", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte AddVulkanRenderSemaphores(SDL_Renderer* renderer, [NativeTypeName("Uint32")] uint wait_stage_mask, [NativeTypeName("Sint64")] long wait_semaphore, [NativeTypeName("Sint64")] long signal_semaphore);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderVSync", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetRenderVSync(SDL_Renderer* renderer, int vsync);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderVSync", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetRenderVSync(SDL_Renderer* renderer, int* vsync);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDebugText", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderDebugText(SDL_Renderer* renderer, float x, float y, [NativeTypeName("const char *")] byte* str);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDebugTextFormat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenderDebugTextFormat(SDL_Renderer* renderer, float x, float y, [NativeTypeName("const char *")] byte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensors", ExactSpelling = true)]
    [return: NativeTypeName("SDL_SensorID *")]
    public static extern uint* GetSensors(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNameForID", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetSensorNameForID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorTypeForID", ExactSpelling = true)]
    public static extern SDL_SensorType GetSensorTypeForID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNonPortableTypeForID", ExactSpelling = true)]
    public static extern int GetSensorNonPortableTypeForID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenSensor", ExactSpelling = true)]
    public static extern SDL_Sensor* OpenSensor([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorFromID", ExactSpelling = true)]
    public static extern SDL_Sensor* GetSensorFromID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetSensorProperties(SDL_Sensor* sensor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetSensorName(SDL_Sensor* sensor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorType", ExactSpelling = true)]
    public static extern SDL_SensorType GetSensorType(SDL_Sensor* sensor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNonPortableType", ExactSpelling = true)]
    public static extern int GetSensorNonPortableType(SDL_Sensor* sensor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorID", ExactSpelling = true)]
    [return: NativeTypeName("SDL_SensorID")]
    public static extern uint GetSensorID(SDL_Sensor* sensor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorData", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetSensorData(SDL_Sensor* sensor, float* data, int num_values);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseSensor", ExactSpelling = true)]
    public static extern void CloseSensor(SDL_Sensor* sensor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateSensors", ExactSpelling = true)]
    public static extern void UpdateSensors();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenTitleStorage", ExactSpelling = true)]
    public static extern SDL_Storage* OpenTitleStorage([NativeTypeName("const char *")] byte* @override, [NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenUserStorage", ExactSpelling = true)]
    public static extern SDL_Storage* OpenUserStorage([NativeTypeName("const char *")] byte* org, [NativeTypeName("const char *")] byte* app, [NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenFileStorage", ExactSpelling = true)]
    public static extern SDL_Storage* OpenFileStorage([NativeTypeName("const char *")] byte* path);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenStorage", ExactSpelling = true)]
    public static extern SDL_Storage* OpenStorage([NativeTypeName("const SDL_StorageInterface *")] SDL_StorageInterface* iface, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseStorage", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CloseStorage(SDL_Storage* storage);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StorageReady", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte StorageReady(SDL_Storage* storage);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageFileSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetStorageFileSize(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("Uint64 *")] ulong* length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadStorageFile", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, void* destination, [NativeTypeName("Uint64")] ulong length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteStorageFile", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const void *")] void* source, [NativeTypeName("Uint64")] ulong length);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateStorageDirectory", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CreateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateStorageDirectory", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte EnumerateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] delegate* unmanaged[Cdecl]<void*, byte*, byte*, SDL_EnumerationResult> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveStoragePath", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RemoveStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenameStoragePath", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RenameStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyStorageFile", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte CopyStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] byte* oldpath, [NativeTypeName("const char *")] byte* newpath);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStoragePathInfo", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetStoragePathInfo(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, SDL_PathInfo* info);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageSpaceRemaining", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetStorageSpaceRemaining(SDL_Storage* storage);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobStorageDirectory", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern byte** GlobStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] byte* path, [NativeTypeName("const char *")] byte* pattern, [NativeTypeName("SDL_GlobFlags")] uint flags, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurface", ExactSpelling = true)]
    public static extern SDL_Surface* CreateSurface(int width, int height, SDL_PixelFormat format);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurfaceFrom", ExactSpelling = true)]
    public static extern SDL_Surface* CreateSurfaceFrom(int width, int height, SDL_PixelFormat format, void* pixels, int pitch);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroySurface", ExactSpelling = true)]
    public static extern void DestroySurface(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetSurfaceProperties(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorspace", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorspace", ExactSpelling = true)]
    public static extern SDL_Colorspace GetSurfaceColorspace(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSurfacePalette", ExactSpelling = true)]
    public static extern SDL_Palette* CreateSurfacePalette(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfacePalette", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfacePalette", ExactSpelling = true)]
    public static extern SDL_Palette* GetSurfacePalette(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddSurfaceAlternateImage", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte AddSurfaceAlternateImage(SDL_Surface* surface, SDL_Surface* image);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasAlternateImages", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SurfaceHasAlternateImages(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceImages", ExactSpelling = true)]
    public static extern SDL_Surface** GetSurfaceImages(SDL_Surface* surface, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveSurfaceAlternateImages", ExactSpelling = true)]
    public static extern void RemoveSurfaceAlternateImages(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte LockSurface(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockSurface", ExactSpelling = true)]
    public static extern void UnlockSurface(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadBMP_IO", ExactSpelling = true)]
    public static extern SDL_Surface* LoadBMP_IO(SDL_IOStream* src, [NativeTypeName("_Bool")] byte closeio);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadBMP", ExactSpelling = true)]
    public static extern SDL_Surface* LoadBMP([NativeTypeName("const char *")] byte* file);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveBMP_IO", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SaveBMP_IO(SDL_Surface* surface, SDL_IOStream* dst, [NativeTypeName("_Bool")] byte closeio);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveBMP", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SaveBMP(SDL_Surface* surface, [NativeTypeName("const char *")] byte* file);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceRLE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetSurfaceRLE(SDL_Surface* surface, [NativeTypeName("_Bool")] byte enabled);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasRLE", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SurfaceHasRLE(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorKey", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("_Bool")] byte enabled, [NativeTypeName("Uint32")] uint key);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SurfaceHasColorKey", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SurfaceHasColorKey(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorKey", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceColorMod", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceColorMod", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceAlphaMod", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte alpha);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceAlphaMod", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceBlendMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetSurfaceBlendMode(SDL_Surface* surface, [NativeTypeName("SDL_BlendMode")] uint blendMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceBlendMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetSurfaceBlendMode(SDL_Surface* surface, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSurfaceClipRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetSurfaceClipRect(SDL_Surface* surface, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSurfaceClipRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlipSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte FlipSurface(SDL_Surface* surface, SDL_FlipMode flip);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DuplicateSurface", ExactSpelling = true)]
    public static extern SDL_Surface* DuplicateSurface(SDL_Surface* surface);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScaleSurface", ExactSpelling = true)]
    public static extern SDL_Surface* ScaleSurface(SDL_Surface* surface, int width, int height, SDL_ScaleMode scaleMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertSurface", ExactSpelling = true)]
    public static extern SDL_Surface* ConvertSurface(SDL_Surface* surface, SDL_PixelFormat format);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertSurfaceAndColorspace", ExactSpelling = true)]
    public static extern SDL_Surface* ConvertSurfaceAndColorspace(SDL_Surface* surface, SDL_PixelFormat format, SDL_Palette* palette, SDL_Colorspace colorspace, [NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertPixels", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ConvertPixels(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, void* dst, int dst_pitch);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertPixelsAndColorspace", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ConvertPixelsAndColorspace(int width, int height, SDL_PixelFormat src_format, SDL_Colorspace src_colorspace, [NativeTypeName("SDL_PropertiesID")] uint src_properties, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, SDL_Colorspace dst_colorspace, [NativeTypeName("SDL_PropertiesID")] uint dst_properties, void* dst, int dst_pitch);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PremultiplyAlpha", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PremultiplyAlpha(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, void* dst, int dst_pitch, [NativeTypeName("_Bool")] byte linear);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PremultiplySurfaceAlpha", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte PremultiplySurfaceAlpha(SDL_Surface* surface, [NativeTypeName("_Bool")] byte linear);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ClearSurface(SDL_Surface* surface, float r, float g, float b, float a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FillSurfaceRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte FillSurfaceRect(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint color);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FillSurfaceRects", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte FillSurfaceRects(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count, [NativeTypeName("Uint32")] uint color);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BlitSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceUnchecked", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BlitSurfaceUnchecked(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceScaled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BlitSurfaceScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceUncheckedScaled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BlitSurfaceUncheckedScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StretchSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte StretchSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceTiled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BlitSurfaceTiled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurfaceTiledWithScale", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BlitSurfaceTiledWithScale(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitSurface9Grid", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte BlitSurface9Grid(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, int left_width, int right_width, int top_height, int bottom_height, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapSurfaceRGB", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint MapSurfaceRGB(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapSurfaceRGBA", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint MapSurfaceRGBA(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadSurfacePixel", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadSurfacePixelFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ReadSurfacePixelFloat(SDL_Surface* surface, int x, int y, float* r, float* g, float* b, float* a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteSurfacePixel", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteSurfacePixelFloat", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WriteSurfacePixelFloat(SDL_Surface* surface, int x, int y, float r, float g, float b, float a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowsMessageHook", ExactSpelling = true)]
    public static extern void SetWindowsMessageHook([NativeTypeName("SDL_WindowsMessageHook")] delegate* unmanaged[Cdecl]<void*, tagMSG*, byte> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDirect3D9AdapterIndex", ExactSpelling = true)]
    public static extern int GetDirect3D9AdapterIndex([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDXGIOutputInfo", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetDXGIOutputInfo([NativeTypeName("SDL_DisplayID")] uint displayID, int* adapterIndex, int* outputIndex);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetX11EventHook", ExactSpelling = true)]
    public static extern void SetX11EventHook([NativeTypeName("SDL_X11EventHook")] delegate* unmanaged[Cdecl]<void*, _XEvent*, byte> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTablet", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsTablet();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTV", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte IsTV();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSandbox", ExactSpelling = true)]
    public static extern SDL_Sandbox GetSandbox();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillTerminate", ExactSpelling = true)]
    public static extern void OnApplicationWillTerminate();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning", ExactSpelling = true)]
    public static extern void OnApplicationDidReceiveMemoryWarning();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillEnterBackground", ExactSpelling = true)]
    public static extern void OnApplicationWillEnterBackground();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidEnterBackground", ExactSpelling = true)]
    public static extern void OnApplicationDidEnterBackground();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillEnterForeground", ExactSpelling = true)]
    public static extern void OnApplicationWillEnterForeground();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidEnterForeground", ExactSpelling = true)]
    public static extern void OnApplicationDidEnterForeground();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadRuntime", ExactSpelling = true)]
    public static extern SDL_Thread* CreateThreadRuntime([NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged[Cdecl]<void*, int> fn, [NativeTypeName("const char *")] byte* name, void* data, [NativeTypeName("SDL_FunctionPointer")] delegate* unmanaged[Cdecl]<void> pfnBeginThread, [NativeTypeName("SDL_FunctionPointer")] delegate* unmanaged[Cdecl]<void> pfnEndThread);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadWithPropertiesRuntime", ExactSpelling = true)]
    public static extern SDL_Thread* CreateThreadWithPropertiesRuntime([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("SDL_FunctionPointer")] delegate* unmanaged[Cdecl]<void> pfnBeginThread, [NativeTypeName("SDL_FunctionPointer")] delegate* unmanaged[Cdecl]<void> pfnEndThread);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetThreadName(SDL_Thread* thread);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentThreadID", ExactSpelling = true)]
    [return: NativeTypeName("SDL_ThreadID")]
    public static extern ulong GetCurrentThreadID();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadID", ExactSpelling = true)]
    [return: NativeTypeName("SDL_ThreadID")]
    public static extern ulong GetThreadID(SDL_Thread* thread);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCurrentThreadPriority", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetCurrentThreadPriority(SDL_ThreadPriority priority);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitThread", ExactSpelling = true)]
    public static extern void WaitThread(SDL_Thread* thread, int* status);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadState", ExactSpelling = true)]
    public static extern SDL_ThreadState GetThreadState(SDL_Thread* thread);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachThread", ExactSpelling = true)]
    public static extern void DetachThread(SDL_Thread* thread);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTLS", ExactSpelling = true)]
    public static extern void* GetTLS([NativeTypeName("SDL_TLSID *")] SDL_AtomicInt* id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTLS", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetTLS([NativeTypeName("SDL_TLSID *")] SDL_AtomicInt* id, [NativeTypeName("const void *")] void* value, [NativeTypeName("SDL_TLSDestructorCallback")] delegate* unmanaged[Cdecl]<void*, void> destructor);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CleanupTLS", ExactSpelling = true)]
    public static extern void CleanupTLS();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDateTimeLocalePreferences", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetDateTimeLocalePreferences(SDL_DateFormat* dateFormat, SDL_TimeFormat* timeFormat);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentTime", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetCurrentTime([NativeTypeName("SDL_Time *")] long* ticks);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeToDateTime", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte TimeToDateTime([NativeTypeName("SDL_Time")] long ticks, SDL_DateTime* dt, [NativeTypeName("_Bool")] byte localTime);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DateTimeToTime", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte DateTimeToTime([NativeTypeName("const SDL_DateTime *")] SDL_DateTime* dt, [NativeTypeName("SDL_Time *")] long* ticks);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeToWindows", ExactSpelling = true)]
    public static extern void TimeToWindows([NativeTypeName("SDL_Time")] long ticks, [NativeTypeName("Uint32 *")] uint* dwLowDateTime, [NativeTypeName("Uint32 *")] uint* dwHighDateTime);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeFromWindows", ExactSpelling = true)]
    [return: NativeTypeName("SDL_Time")]
    public static extern long TimeFromWindows([NativeTypeName("Uint32")] uint dwLowDateTime, [NativeTypeName("Uint32")] uint dwHighDateTime);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDaysInMonth", ExactSpelling = true)]
    public static extern int GetDaysInMonth(int year, int month);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDayOfYear", ExactSpelling = true)]
    public static extern int GetDayOfYear(int year, int month, int day);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDayOfWeek", ExactSpelling = true)]
    public static extern int GetDayOfWeek(int year, int month, int day);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicks", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetTicks();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicksNS", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetTicksNS();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceCounter", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetPerformanceCounter();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceFrequency", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetPerformanceFrequency();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Delay", ExactSpelling = true)]
    public static extern void Delay([NativeTypeName("Uint32")] uint ms);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayNS", ExactSpelling = true)]
    public static extern void DelayNS([NativeTypeName("Uint64")] ulong ns);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayPrecise", ExactSpelling = true)]
    public static extern void DelayPrecise([NativeTypeName("Uint64")] ulong ns);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimer", ExactSpelling = true)]
    [return: NativeTypeName("SDL_TimerID")]
    public static extern uint AddTimer([NativeTypeName("Uint32")] uint interval, [NativeTypeName("SDL_TimerCallback")] delegate* unmanaged[Cdecl]<void*, uint, uint, uint> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimerNS", ExactSpelling = true)]
    [return: NativeTypeName("SDL_TimerID")]
    public static extern uint AddTimerNS([NativeTypeName("Uint64")] ulong interval, [NativeTypeName("SDL_NSTimerCallback")] delegate* unmanaged[Cdecl]<void*, uint, ulong, ulong> callback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveTimer", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);

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
    public static extern void SetTrayEntryChecked(SDL_TrayEntry* entry, [NativeTypeName("_Bool")] byte @checked);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryChecked", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTrayEntryChecked(SDL_TrayEntry* entry);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryEnabled", ExactSpelling = true)]
    public static extern void SetTrayEntryEnabled(SDL_TrayEntry* entry, [NativeTypeName("_Bool")] byte enabled);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryEnabled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetTrayEntryEnabled(SDL_TrayEntry* entry);

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

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDevices", ExactSpelling = true)]
    [return: NativeTypeName("SDL_TouchID *")]
    public static extern ulong* GetTouchDevices(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetTouchDeviceName([NativeTypeName("SDL_TouchID")] ulong touchID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceType", ExactSpelling = true)]
    public static extern SDL_TouchDeviceType GetTouchDeviceType([NativeTypeName("SDL_TouchID")] ulong touchID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchFingers", ExactSpelling = true)]
    public static extern SDL_Finger** GetTouchFingers([NativeTypeName("SDL_TouchID")] ulong touchID, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVersion", ExactSpelling = true)]
    public static extern int GetVersion();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRevision", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetRevision();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumVideoDrivers", ExactSpelling = true)]
    public static extern int GetNumVideoDrivers();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVideoDriver", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetVideoDriver(int index);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentVideoDriver", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetCurrentVideoDriver();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemTheme", ExactSpelling = true)]
    public static extern SDL_SystemTheme GetSystemTheme();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplays", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID *")]
    public static extern uint* GetDisplays(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimaryDisplay", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID")]
    public static extern uint GetPrimaryDisplay();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetDisplayProperties([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayName", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetDisplayName([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayBounds", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetDisplayBounds([NativeTypeName("SDL_DisplayID")] uint displayID, SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayUsableBounds", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetDisplayUsableBounds([NativeTypeName("SDL_DisplayID")] uint displayID, SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNaturalDisplayOrientation", ExactSpelling = true)]
    public static extern SDL_DisplayOrientation GetNaturalDisplayOrientation([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayOrientation", ExactSpelling = true)]
    public static extern SDL_DisplayOrientation GetCurrentDisplayOrientation([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayContentScale", ExactSpelling = true)]
    public static extern float GetDisplayContentScale([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFullscreenDisplayModes", ExactSpelling = true)]
    public static extern SDL_DisplayMode** GetFullscreenDisplayModes([NativeTypeName("SDL_DisplayID")] uint displayID, int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClosestFullscreenDisplayMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetClosestFullscreenDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID, int w, int h, float refresh_rate, [NativeTypeName("_Bool")] byte include_high_density_modes, SDL_DisplayMode* closest);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDesktopDisplayMode", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_DisplayMode *")]
    public static extern SDL_DisplayMode* GetDesktopDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayMode", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_DisplayMode *")]
    public static extern SDL_DisplayMode* GetCurrentDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForPoint", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID")]
    public static extern uint GetDisplayForPoint([NativeTypeName("const SDL_Point *")] SDL_Point* point);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForRect", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID")]
    public static extern uint GetDisplayForRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForWindow", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID")]
    public static extern uint GetDisplayForWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelDensity", ExactSpelling = true)]
    public static extern float GetWindowPixelDensity(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowDisplayScale", ExactSpelling = true)]
    public static extern float GetWindowDisplayScale(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreenMode", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowFullscreenMode(SDL_Window* window, [NativeTypeName("const SDL_DisplayMode *")] SDL_DisplayMode* mode);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFullscreenMode", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_DisplayMode *")]
    public static extern SDL_DisplayMode* GetWindowFullscreenMode(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowICCProfile", ExactSpelling = true)]
    public static extern void* GetWindowICCProfile(SDL_Window* window, [NativeTypeName("size_t *")] nuint* size);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelFormat", ExactSpelling = true)]
    public static extern SDL_PixelFormat GetWindowPixelFormat(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindows", ExactSpelling = true)]
    public static extern SDL_Window** GetWindows(int* count);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
    public static extern SDL_Window* CreateWindow([NativeTypeName("const char *")] byte* title, int w, int h, [NativeTypeName("SDL_WindowFlags")] ulong flags);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreatePopupWindow", ExactSpelling = true)]
    public static extern SDL_Window* CreatePopupWindow(SDL_Window* parent, int offset_x, int offset_y, int w, int h, [NativeTypeName("SDL_WindowFlags")] ulong flags);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowWithProperties", ExactSpelling = true)]
    public static extern SDL_Window* CreateWindowWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowID", ExactSpelling = true)]
    [return: NativeTypeName("SDL_WindowID")]
    public static extern uint GetWindowID(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFromID", ExactSpelling = true)]
    public static extern SDL_Window* GetWindowFromID([NativeTypeName("SDL_WindowID")] uint id);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowParent", ExactSpelling = true)]
    public static extern SDL_Window* GetWindowParent(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowProperties", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetWindowProperties(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFlags", ExactSpelling = true)]
    [return: NativeTypeName("SDL_WindowFlags")]
    public static extern ulong GetWindowFlags(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowTitle", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowTitle(SDL_Window* window, [NativeTypeName("const char *")] byte* title);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowTitle", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern byte* GetWindowTitle(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowIcon", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowPosition", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowPosition(SDL_Window* window, int x, int y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPosition", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowPosition(SDL_Window* window, int* x, int* y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowSize(SDL_Window* window, int w, int h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowSize(SDL_Window* window, int* w, int* h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSafeArea", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowSafeArea(SDL_Window* window, SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAspectRatio", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowAspectRatio(SDL_Window* window, float min_aspect, float max_aspect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowAspectRatio", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowAspectRatio(SDL_Window* window, float* min_aspect, float* max_aspect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowBordersSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSizeInPixels", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowSizeInPixels(SDL_Window* window, int* w, int* h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMinimumSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMinimumSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowMinimumSize(SDL_Window* window, int* w, int* h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMaximumSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMaximumSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowMaximumSize(SDL_Window* window, int* w, int* h);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowBordered", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowBordered(SDL_Window* window, [NativeTypeName("_Bool")] byte bordered);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowResizable", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowResizable(SDL_Window* window, [NativeTypeName("_Bool")] byte resizable);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAlwaysOnTop", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowAlwaysOnTop(SDL_Window* window, [NativeTypeName("_Bool")] byte on_top);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ShowWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte HideWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RaiseWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RaiseWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MaximizeWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte MaximizeWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MinimizeWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte MinimizeWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RestoreWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte RestoreWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreen", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowFullscreen(SDL_Window* window, [NativeTypeName("_Bool")] byte fullscreen);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SyncWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SyncWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowHasSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte WindowHasSurface(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurface", ExactSpelling = true)]
    public static extern SDL_Surface* GetWindowSurface(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSurfaceVSync", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowSurfaceVSync(SDL_Window* window, int vsync);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurfaceVSync", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowSurfaceVSync(SDL_Window* window, int* vsync);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte UpdateWindowSurface(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurfaceRects", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte UpdateWindowSurfaceRects(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int numrects);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindowSurface", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte DestroyWindowSurface(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowKeyboardGrab", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowKeyboardGrab(SDL_Window* window, [NativeTypeName("_Bool")] byte grabbed);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseGrab", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowMouseGrab(SDL_Window* window, [NativeTypeName("_Bool")] byte grabbed);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowKeyboardGrab", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowKeyboardGrab(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseGrab", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GetWindowMouseGrab(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGrabbedWindow", ExactSpelling = true)]
    public static extern SDL_Window* GetGrabbedWindow();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseRect", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowMouseRect(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseRect", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_Rect *")]
    public static extern SDL_Rect* GetWindowMouseRect(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowOpacity", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowOpacity(SDL_Window* window, float opacity);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowOpacity", ExactSpelling = true)]
    public static extern float GetWindowOpacity(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowParent", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowParent(SDL_Window* window, SDL_Window* parent);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowModal", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowModal(SDL_Window* window, [NativeTypeName("_Bool")] byte modal);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFocusable", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowFocusable(SDL_Window* window, [NativeTypeName("_Bool")] byte focusable);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindowSystemMenu", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ShowWindowSystemMenu(SDL_Window* window, int x, int y);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowHitTest", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowHitTest(SDL_Window* window, [NativeTypeName("SDL_HitTest")] delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> callback, void* callback_data);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowShape", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte SetWindowShape(SDL_Window* window, SDL_Surface* shape);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlashWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
    public static extern void DestroyWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScreenSaverEnabled", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte ScreenSaverEnabled();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnableScreenSaver", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte EnableScreenSaver();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DisableScreenSaver", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte DisableScreenSaver();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_LoadLibrary", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_LoadLibrary([NativeTypeName("const char *")] byte* path);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged[Cdecl]<void> GL_GetProcAddress([NativeTypeName("const char *")] byte* proc);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetProcAddress", ExactSpelling = true)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged[Cdecl]<void> EGL_GetProcAddress([NativeTypeName("const char *")] byte* proc);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_UnloadLibrary", ExactSpelling = true)]
    public static extern void GL_UnloadLibrary();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ExtensionSupported", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_ExtensionSupported([NativeTypeName("const char *")] byte* extension);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ResetAttributes", ExactSpelling = true)]
    public static extern void GL_ResetAttributes();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetAttribute", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_SetAttribute(SDL_GLAttr attr, int value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetAttribute", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_GetAttribute(SDL_GLAttr attr, int* value);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
    [return: NativeTypeName("SDL_GLContext")]
    public static extern SDL_GLContextState* GL_CreateContext(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_MakeCurrent(SDL_Window* window, [NativeTypeName("SDL_GLContext")] SDL_GLContextState* context);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentWindow", ExactSpelling = true)]
    public static extern SDL_Window* GL_GetCurrentWindow();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
    [return: NativeTypeName("SDL_GLContext")]
    public static extern SDL_GLContextState* GL_GetCurrentContext();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetCurrentDisplay", ExactSpelling = true)]
    [return: NativeTypeName("SDL_EGLDisplay")]
    public static extern void* EGL_GetCurrentDisplay();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetCurrentConfig", ExactSpelling = true)]
    [return: NativeTypeName("SDL_EGLConfig")]
    public static extern void* EGL_GetCurrentConfig();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetWindowSurface", ExactSpelling = true)]
    [return: NativeTypeName("SDL_EGLSurface")]
    public static extern void* EGL_GetWindowSurface(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_SetAttributeCallbacks", ExactSpelling = true)]
    public static extern void EGL_SetAttributeCallbacks([NativeTypeName("SDL_EGLAttribArrayCallback")] delegate* unmanaged[Cdecl]<void*, nint*> platformAttribCallback, [NativeTypeName("SDL_EGLIntArrayCallback")] delegate* unmanaged[Cdecl]<void*, void*, void*, int*> surfaceAttribCallback, [NativeTypeName("SDL_EGLIntArrayCallback")] delegate* unmanaged[Cdecl]<void*, void*, void*, int*> contextAttribCallback, void* userdata);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetSwapInterval", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_SetSwapInterval(int interval);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetSwapInterval", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_GetSwapInterval(int* interval);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_SwapWindow(SDL_Window* window);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_DestroyContext", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern byte GL_DestroyContext([NativeTypeName("SDL_GLContext")] SDL_GLContextState* context);
}
