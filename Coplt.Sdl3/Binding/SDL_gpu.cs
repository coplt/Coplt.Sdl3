using System.Runtime.InteropServices;

namespace Coplt.Sdl3
{
    public partial struct SDL_GPUDevice
    {
    }

    public partial struct SDL_GPUBuffer
    {
    }

    public partial struct SDL_GPUTransferBuffer
    {
    }

    public partial struct SDL_GPUTexture
    {
    }

    public partial struct SDL_GPUSampler
    {
    }

    public partial struct SDL_GPUShader
    {
    }

    public partial struct SDL_GPUComputePipeline
    {
    }

    public partial struct SDL_GPUGraphicsPipeline
    {
    }

    public partial struct SDL_GPUCommandBuffer
    {
    }

    public partial struct SDL_GPURenderPass
    {
    }

    public partial struct SDL_GPUComputePass
    {
    }

    public partial struct SDL_GPUCopyPass
    {
    }

    public partial struct SDL_GPUFence
    {
    }

    public enum SDL_GPUPrimitiveType
    {
        Trianglelist,
        Trianglestrip,
        Linelist,
        Linestrip,
        Pointlist,
    }

    public enum SDL_GPULoadOp
    {
        Load,
        Clear,
        DontCare,
    }

    public enum SDL_GPUStoreOp
    {
        Store,
        DontCare,
        Resolve,
        ResolveAndStore,
    }

    public enum SDL_GPUIndexElementSize
    {
        _16bit,
        _32bit,
    }

    public enum SDL_GPUTextureFormat
    {
        Invalid,
        A8Unorm,
        R8Unorm,
        R8g8Unorm,
        R8g8b8a8Unorm,
        R16Unorm,
        R16g16Unorm,
        R16g16b16a16Unorm,
        R10g10b10a2Unorm,
        B5g6r5Unorm,
        B5g5r5a1Unorm,
        B4g4r4a4Unorm,
        B8g8r8a8Unorm,
        Bc1RgbaUnorm,
        Bc2RgbaUnorm,
        Bc3RgbaUnorm,
        Bc4RUnorm,
        Bc5RgUnorm,
        Bc7RgbaUnorm,
        Bc6hRgbFloat,
        Bc6hRgbUfloat,
        R8Snorm,
        R8g8Snorm,
        R8g8b8a8Snorm,
        R16Snorm,
        R16g16Snorm,
        R16g16b16a16Snorm,
        R16Float,
        R16g16Float,
        R16g16b16a16Float,
        R32Float,
        R32g32Float,
        R32g32b32a32Float,
        R11g11b10Ufloat,
        R8Uint,
        R8g8Uint,
        R8g8b8a8Uint,
        R16Uint,
        R16g16Uint,
        R16g16b16a16Uint,
        R32Uint,
        R32g32Uint,
        R32g32b32a32Uint,
        R8Int,
        R8g8Int,
        R8g8b8a8Int,
        R16Int,
        R16g16Int,
        R16g16b16a16Int,
        R32Int,
        R32g32Int,
        R32g32b32a32Int,
        R8g8b8a8UnormSrgb,
        B8g8r8a8UnormSrgb,
        Bc1RgbaUnormSrgb,
        Bc2RgbaUnormSrgb,
        Bc3RgbaUnormSrgb,
        Bc7RgbaUnormSrgb,
        D16Unorm,
        D24Unorm,
        D32Float,
        D24UnormS8Uint,
        D32FloatS8Uint,
        Astc_4x4Unorm,
        Astc_5x4Unorm,
        Astc_5x5Unorm,
        Astc_6x5Unorm,
        Astc_6x6Unorm,
        Astc_8x5Unorm,
        Astc_8x6Unorm,
        Astc_8x8Unorm,
        Astc_10x5Unorm,
        Astc_10x6Unorm,
        Astc_10x8Unorm,
        Astc_10x10Unorm,
        Astc_12x10Unorm,
        Astc_12x12Unorm,
        Astc_4x4UnormSrgb,
        Astc_5x4UnormSrgb,
        Astc_5x5UnormSrgb,
        Astc_6x5UnormSrgb,
        Astc_6x6UnormSrgb,
        Astc_8x5UnormSrgb,
        Astc_8x6UnormSrgb,
        Astc_8x8UnormSrgb,
        Astc_10x5UnormSrgb,
        Astc_10x6UnormSrgb,
        Astc_10x8UnormSrgb,
        Astc_10x10UnormSrgb,
        Astc_12x10UnormSrgb,
        Astc_12x12UnormSrgb,
        Astc_4x4Float,
        Astc_5x4Float,
        Astc_5x5Float,
        Astc_6x5Float,
        Astc_6x6Float,
        Astc_8x5Float,
        Astc_8x6Float,
        Astc_8x8Float,
        Astc_10x5Float,
        Astc_10x6Float,
        Astc_10x8Float,
        Astc_10x10Float,
        Astc_12x10Float,
        Astc_12x12Float,
    }

    public enum SDL_GPUTextureType
    {
        _2d,
        _2dArray,
        _3d,
        Cube,
        CubeArray,
    }

    public enum SDL_GPUSampleCount
    {
        _1,
        _2,
        _4,
        _8,
    }

    public enum SDL_GPUCubeMapFace
    {
        Positivex,
        Negativex,
        Positivey,
        Negativey,
        Positivez,
        Negativez,
    }

    public enum SDL_GPUTransferBufferUsage
    {
        Upload,
        Download,
    }

    public enum SDL_GPUShaderStage
    {
        Vertex,
        Fragment,
    }

    public enum SDL_GPUVertexElementFormat
    {
        Invalid,
        Int,
        Int2,
        Int3,
        Int4,
        Uint,
        Uint2,
        Uint3,
        Uint4,
        Float,
        Float2,
        Float3,
        Float4,
        Byte2,
        Byte4,
        Ubyte2,
        Ubyte4,
        Byte2Norm,
        Byte4Norm,
        Ubyte2Norm,
        Ubyte4Norm,
        Short2,
        Short4,
        Ushort2,
        Ushort4,
        Short2Norm,
        Short4Norm,
        Ushort2Norm,
        Ushort4Norm,
        Half2,
        Half4,
    }

    public enum SDL_GPUVertexInputRate
    {
        Vertex,
        Instance,
    }

    public enum SDL_GPUFillMode
    {
        Fill,
        Line,
    }

    public enum SDL_GPUCullMode
    {
        None,
        Front,
        Back,
    }

    public enum SDL_GPUFrontFace
    {
        CounterClockwise,
        Clockwise,
    }

    public enum SDL_GPUCompareOp
    {
        Invalid,
        Never,
        Less,
        Equal,
        LessOrEqual,
        Greater,
        NotEqual,
        GreaterOrEqual,
        Always,
    }

    public enum SDL_GPUStencilOp
    {
        Invalid,
        Keep,
        Zero,
        Replace,
        IncrementAndClamp,
        DecrementAndClamp,
        Invert,
        IncrementAndWrap,
        DecrementAndWrap,
    }

    public enum SDL_GPUBlendOp
    {
        Invalid,
        Add,
        Subtract,
        ReverseSubtract,
        Min,
        Max,
    }

    public enum SDL_GPUBlendFactor
    {
        Invalid,
        Zero,
        One,
        SrcColor,
        OneMinusSrcColor,
        DstColor,
        OneMinusDstColor,
        SrcAlpha,
        OneMinusSrcAlpha,
        DstAlpha,
        OneMinusDstAlpha,
        ConstantColor,
        OneMinusConstantColor,
        SrcAlphaSaturate,
    }

    public enum SDL_GPUFilter
    {
        Nearest,
        Linear,
    }

    public enum SDL_GPUSamplerMipmapMode
    {
        Nearest,
        Linear,
    }

    public enum SDL_GPUSamplerAddressMode
    {
        Repeat,
        MirroredRepeat,
        ClampToEdge,
    }

    public enum SDL_GPUPresentMode
    {
        Vsync,
        Immediate,
        Mailbox,
    }

    public enum SDL_GPUSwapchainComposition
    {
        Sdr,
        SdrLinear,
        HdrExtendedLinear,
        Hdr10St2084,
    }

    public partial struct SDL_GPUViewport
    {
        public float x;

        public float y;

        public float w;

        public float h;

        public float min_depth;

        public float max_depth;
    }

    public unsafe partial struct SDL_GPUTextureTransferInfo
    {
        public SDL_GPUTransferBuffer* transfer_buffer;
        public uint offset;
        public uint pixels_per_row;
        public uint rows_per_layer;
    }

    public unsafe partial struct SDL_GPUTransferBufferLocation
    {
        public SDL_GPUTransferBuffer* transfer_buffer;
        public uint offset;
    }

    public unsafe partial struct SDL_GPUTextureLocation
    {
        public SDL_GPUTexture* texture;
        public uint mip_level;
        public uint layer;
        public uint x;
        public uint y;
        public uint z;
    }

    public unsafe partial struct SDL_GPUTextureRegion
    {
        public SDL_GPUTexture* texture;
        public uint mip_level;
        public uint layer;
        public uint x;
        public uint y;
        public uint z;
        public uint w;
        public uint h;
        public uint d;
    }

    public unsafe partial struct SDL_GPUBlitRegion
    {
        public SDL_GPUTexture* texture;
        public uint mip_level;
        public uint layer_or_depth_plane;
        public uint x;
        public uint y;
        public uint w;
        public uint h;
    }

    public unsafe partial struct SDL_GPUBufferLocation
    {
        public SDL_GPUBuffer* buffer;
        public uint offset;
    }

    public unsafe partial struct SDL_GPUBufferRegion
    {
        public SDL_GPUBuffer* buffer;
        public uint offset;
        public uint size;
    }

    public partial struct SDL_GPUIndirectDrawCommand
    {
        public uint num_vertices;
        public uint num_instances;
        public uint first_vertex;
        public uint first_instance;
    }

    public partial struct SDL_GPUIndexedIndirectDrawCommand
    {
        public uint num_indices;
        public uint num_instances;
        public uint first_index;
        public int vertex_offset;
        public uint first_instance;
    }

    public partial struct SDL_GPUIndirectDispatchCommand
    {
        public uint groupcount_x;
        public uint groupcount_y;
        public uint groupcount_z;
    }

    public partial struct SDL_GPUSamplerCreateInfo
    {
        public SDL_GPUFilter min_filter;

        public SDL_GPUFilter mag_filter;

        public SDL_GPUSamplerMipmapMode mipmap_mode;

        public SDL_GPUSamplerAddressMode address_mode_u;

        public SDL_GPUSamplerAddressMode address_mode_v;

        public SDL_GPUSamplerAddressMode address_mode_w;

        public float mip_lod_bias;

        public float max_anisotropy;

        public SDL_GPUCompareOp compare_op;

        public float min_lod;

        public float max_lod;
        public bool8 enable_anisotropy;
        public bool8 enable_compare;
        public byte padding1;
        public byte padding2;

        public SDL_PropertiesID props;
    }

    public partial struct SDL_GPUVertexBufferDescription
    {
        public uint slot;
        public uint pitch;

        public SDL_GPUVertexInputRate input_rate;
        public uint instance_step_rate;
    }

    public partial struct SDL_GPUVertexAttribute
    {
        public uint location;
        public uint buffer_slot;

        public SDL_GPUVertexElementFormat format;
        public uint offset;
    }

    public unsafe partial struct SDL_GPUVertexInputState
    {
        public SDL_GPUVertexBufferDescription* vertex_buffer_descriptions;
        public uint num_vertex_buffers;
        public SDL_GPUVertexAttribute* vertex_attributes;
        public uint num_vertex_attributes;
    }

    public partial struct SDL_GPUStencilOpState
    {
        public SDL_GPUStencilOp fail_op;

        public SDL_GPUStencilOp pass_op;

        public SDL_GPUStencilOp depth_fail_op;

        public SDL_GPUCompareOp compare_op;
    }

    public partial struct SDL_GPUColorTargetBlendState
    {
        public SDL_GPUBlendFactor src_color_blendfactor;

        public SDL_GPUBlendFactor dst_color_blendfactor;

        public SDL_GPUBlendOp color_blend_op;

        public SDL_GPUBlendFactor src_alpha_blendfactor;

        public SDL_GPUBlendFactor dst_alpha_blendfactor;

        public SDL_GPUBlendOp alpha_blend_op;

        public SDL_GPUColorComponentFlags color_write_mask;
        public bool8 enable_blend;
        public bool8 enable_color_write_mask;
        public byte padding1;
        public byte padding2;
    }

    public unsafe partial struct SDL_GPUShaderCreateInfo
    {
        public nuint code_size;
        public byte* code;
        public byte* entrypoint;

        public SDL_GPUShaderFormat format;

        public SDL_GPUShaderStage stage;
        public uint num_samplers;
        public uint num_storage_textures;
        public uint num_storage_buffers;
        public uint num_uniform_buffers;

        public SDL_PropertiesID props;
    }

    public partial struct SDL_GPUTextureCreateInfo
    {
        public SDL_GPUTextureType type;

        public SDL_GPUTextureFormat format;

        public SDL_GPUTextureUsageFlags usage;
        public uint width;
        public uint height;
        public uint layer_count_or_depth;
        public uint num_levels;

        public SDL_GPUSampleCount sample_count;

        public SDL_PropertiesID props;
    }

    public partial struct SDL_GPUBufferCreateInfo
    {
        public SDL_GPUBufferUsageFlags usage;
        public uint size;

        public SDL_PropertiesID props;
    }

    public partial struct SDL_GPUTransferBufferCreateInfo
    {
        public SDL_GPUTransferBufferUsage usage;
        public uint size;

        public SDL_PropertiesID props;
    }

    public partial struct SDL_GPURasterizerState
    {
        public SDL_GPUFillMode fill_mode;

        public SDL_GPUCullMode cull_mode;

        public SDL_GPUFrontFace front_face;

        public float depth_bias_constant_factor;

        public float depth_bias_clamp;

        public float depth_bias_slope_factor;
        public bool8 enable_depth_bias;
        public bool8 enable_depth_clip;
        public byte padding1;
        public byte padding2;
    }

    public partial struct SDL_GPUMultisampleState
    {
        public SDL_GPUSampleCount sample_count;
        public uint sample_mask;
        public bool8 enable_mask;
        public byte padding1;
        public byte padding2;
        public byte padding3;
    }

    public partial struct SDL_GPUDepthStencilState
    {
        public SDL_GPUCompareOp compare_op;

        public SDL_GPUStencilOpState back_stencil_state;

        public SDL_GPUStencilOpState front_stencil_state;
        public byte compare_mask;
        public byte write_mask;
        public bool8 enable_depth_test;
        public bool8 enable_depth_write;
        public bool8 enable_stencil_test;
        public byte padding1;
        public byte padding2;
        public byte padding3;
    }

    public partial struct SDL_GPUColorTargetDescription
    {
        public SDL_GPUTextureFormat format;

        public SDL_GPUColorTargetBlendState blend_state;
    }

    public unsafe partial struct SDL_GPUGraphicsPipelineTargetInfo
    {
        public SDL_GPUColorTargetDescription* color_target_descriptions;
        public uint num_color_targets;

        public SDL_GPUTextureFormat depth_stencil_format;
        public bool8 has_depth_stencil_target;
        public byte padding1;
        public byte padding2;
        public byte padding3;
    }

    public unsafe partial struct SDL_GPUGraphicsPipelineCreateInfo
    {
        public SDL_GPUShader* vertex_shader;

        public SDL_GPUShader* fragment_shader;

        public SDL_GPUVertexInputState vertex_input_state;

        public SDL_GPUPrimitiveType primitive_type;

        public SDL_GPURasterizerState rasterizer_state;

        public SDL_GPUMultisampleState multisample_state;

        public SDL_GPUDepthStencilState depth_stencil_state;

        public SDL_GPUGraphicsPipelineTargetInfo target_info;

        public SDL_PropertiesID props;
    }

    public unsafe partial struct SDL_GPUComputePipelineCreateInfo
    {
        public nuint code_size;
        public byte* code;
        public byte* entrypoint;

        public SDL_GPUShaderFormat format;
        public uint num_samplers;
        public uint num_readonly_storage_textures;
        public uint num_readonly_storage_buffers;
        public uint num_readwrite_storage_textures;
        public uint num_readwrite_storage_buffers;
        public uint num_uniform_buffers;
        public uint threadcount_x;
        public uint threadcount_y;
        public uint threadcount_z;

        public SDL_PropertiesID props;
    }

    public unsafe partial struct SDL_GPUColorTargetInfo
    {
        public SDL_GPUTexture* texture;
        public uint mip_level;
        public uint layer_or_depth_plane;

        public SDL_FColor clear_color;

        public SDL_GPULoadOp load_op;

        public SDL_GPUStoreOp store_op;

        public SDL_GPUTexture* resolve_texture;
        public uint resolve_mip_level;
        public uint resolve_layer;
        public bool8 cycle;
        public bool8 cycle_resolve_texture;
        public byte padding1;
        public byte padding2;
    }

    public unsafe partial struct SDL_GPUDepthStencilTargetInfo
    {
        public SDL_GPUTexture* texture;

        public float clear_depth;

        public SDL_GPULoadOp load_op;

        public SDL_GPUStoreOp store_op;

        public SDL_GPULoadOp stencil_load_op;

        public SDL_GPUStoreOp stencil_store_op;
        public bool8 cycle;
        public byte clear_stencil;
        public byte padding1;
        public byte padding2;
    }

    public partial struct SDL_GPUBlitInfo
    {
        public SDL_GPUBlitRegion source;

        public SDL_GPUBlitRegion destination;

        public SDL_GPULoadOp load_op;

        public SDL_FColor clear_color;

        public SDL_FlipMode flip_mode;

        public SDL_GPUFilter filter;
        public bool8 cycle;
        public byte padding1;
        public byte padding2;
        public byte padding3;
    }

    public unsafe partial struct SDL_GPUBufferBinding
    {
        public SDL_GPUBuffer* buffer;
        public uint offset;
    }

    public unsafe partial struct SDL_GPUTextureSamplerBinding
    {
        public SDL_GPUTexture* texture;

        public SDL_GPUSampler* sampler;
    }

    public unsafe partial struct SDL_GPUStorageBufferReadWriteBinding
    {
        public SDL_GPUBuffer* buffer;
        public bool8 cycle;
        public byte padding1;
        public byte padding2;
        public byte padding3;
    }

    public unsafe partial struct SDL_GPUStorageTextureReadWriteBinding
    {
        public SDL_GPUTexture* texture;
        public uint mip_level;
        public uint layer;
        public bool8 cycle;
        public byte padding1;
        public byte padding2;
        public byte padding3;
    }

    public static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUSupportsShaderFormats", ExactSpelling = true)]
        public static extern bool8 GPUSupportsShaderFormats(SDL_GPUShaderFormat format_flags,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUSupportsProperties", ExactSpelling = true)]
        public static extern bool8 GPUSupportsProperties(SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUDevice", ExactSpelling = true)]
        public static extern SDL_GPUDevice* CreateGPUDevice(SDL_GPUShaderFormat format_flags,bool8 debug_mode,byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUDeviceWithProperties", ExactSpelling = true)]
        public static extern SDL_GPUDevice* CreateGPUDeviceWithProperties(SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyGPUDevice", ExactSpelling = true)]
        public static extern void DestroyGPUDevice(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGPUDrivers", ExactSpelling = true)]
        public static extern int GetNumGPUDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUDriver", ExactSpelling = true)]
        public static extern byte* GetGPUDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUDeviceDriver", ExactSpelling = true)]
        public static extern byte* GetGPUDeviceDriver(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUShaderFormats", ExactSpelling = true)]
        public static extern SDL_GPUShaderFormat GetGPUShaderFormats(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUComputePipeline", ExactSpelling = true)]
        public static extern SDL_GPUComputePipeline* CreateGPUComputePipeline(SDL_GPUDevice* device,SDL_GPUComputePipelineCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUGraphicsPipeline", ExactSpelling = true)]
        public static extern SDL_GPUGraphicsPipeline* CreateGPUGraphicsPipeline(SDL_GPUDevice* device,SDL_GPUGraphicsPipelineCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUSampler", ExactSpelling = true)]
        public static extern SDL_GPUSampler* CreateGPUSampler(SDL_GPUDevice* device,SDL_GPUSamplerCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUShader", ExactSpelling = true)]
        public static extern SDL_GPUShader* CreateGPUShader(SDL_GPUDevice* device,SDL_GPUShaderCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUTexture", ExactSpelling = true)]
        public static extern SDL_GPUTexture* CreateGPUTexture(SDL_GPUDevice* device,SDL_GPUTextureCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUBuffer", ExactSpelling = true)]
        public static extern SDL_GPUBuffer* CreateGPUBuffer(SDL_GPUDevice* device,SDL_GPUBufferCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPUTransferBuffer", ExactSpelling = true)]
        public static extern SDL_GPUTransferBuffer* CreateGPUTransferBuffer(SDL_GPUDevice* device,SDL_GPUTransferBufferCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUBufferName", ExactSpelling = true)]
        public static extern void SetGPUBufferName(SDL_GPUDevice* device, SDL_GPUBuffer* buffer,byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUTextureName", ExactSpelling = true)]
        public static extern void SetGPUTextureName(SDL_GPUDevice* device, SDL_GPUTexture* texture,byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InsertGPUDebugLabel", ExactSpelling = true)]
        public static extern void InsertGPUDebugLabel(SDL_GPUCommandBuffer* command_buffer,byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUDebugGroup", ExactSpelling = true)]
        public static extern void PushGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer,byte* name);

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
        public static extern void PushGPUVertexUniformData(SDL_GPUCommandBuffer* command_buffer,uint slot_index,void* data,uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUFragmentUniformData", ExactSpelling = true)]
        public static extern void PushGPUFragmentUniformData(SDL_GPUCommandBuffer* command_buffer,uint slot_index,void* data,uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushGPUComputeUniformData", ExactSpelling = true)]
        public static extern void PushGPUComputeUniformData(SDL_GPUCommandBuffer* command_buffer,uint slot_index,void* data,uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPURenderPass", ExactSpelling = true)]
        public static extern SDL_GPURenderPass* BeginGPURenderPass(SDL_GPUCommandBuffer* command_buffer,SDL_GPUColorTargetInfo* color_target_infos,uint num_color_targets,SDL_GPUDepthStencilTargetInfo* depth_stencil_target_info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUGraphicsPipeline", ExactSpelling = true)]
        public static extern void BindGPUGraphicsPipeline(SDL_GPURenderPass* render_pass, SDL_GPUGraphicsPipeline* graphics_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUViewport", ExactSpelling = true)]
        public static extern void SetGPUViewport(SDL_GPURenderPass* render_pass,SDL_GPUViewport* viewport);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUScissor", ExactSpelling = true)]
        public static extern void SetGPUScissor(SDL_GPURenderPass* render_pass,SDL_Rect* scissor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUBlendConstants", ExactSpelling = true)]
        public static extern void SetGPUBlendConstants(SDL_GPURenderPass* render_pass, SDL_FColor blend_constants);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUStencilReference", ExactSpelling = true)]
        public static extern void SetGPUStencilReference(SDL_GPURenderPass* render_pass,byte reference);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexBuffers", ExactSpelling = true)]
        public static extern void BindGPUVertexBuffers(SDL_GPURenderPass* render_pass,uint first_slot,SDL_GPUBufferBinding* bindings,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUIndexBuffer", ExactSpelling = true)]
        public static extern void BindGPUIndexBuffer(SDL_GPURenderPass* render_pass,SDL_GPUBufferBinding* binding, SDL_GPUIndexElementSize index_element_size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexSamplers", ExactSpelling = true)]
        public static extern void BindGPUVertexSamplers(SDL_GPURenderPass* render_pass,uint first_slot,SDL_GPUTextureSamplerBinding* texture_sampler_bindings,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexStorageTextures", ExactSpelling = true)]
        public static extern void BindGPUVertexStorageTextures(SDL_GPURenderPass* render_pass,uint first_slot,SDL_GPUTexture** storage_textures,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUVertexStorageBuffers", ExactSpelling = true)]
        public static extern void BindGPUVertexStorageBuffers(SDL_GPURenderPass* render_pass,uint first_slot,SDL_GPUBuffer** storage_buffers,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentSamplers", ExactSpelling = true)]
        public static extern void BindGPUFragmentSamplers(SDL_GPURenderPass* render_pass,uint first_slot,SDL_GPUTextureSamplerBinding* texture_sampler_bindings,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentStorageTextures", ExactSpelling = true)]
        public static extern void BindGPUFragmentStorageTextures(SDL_GPURenderPass* render_pass,uint first_slot,SDL_GPUTexture** storage_textures,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUFragmentStorageBuffers", ExactSpelling = true)]
        public static extern void BindGPUFragmentStorageBuffers(SDL_GPURenderPass* render_pass,uint first_slot,SDL_GPUBuffer** storage_buffers,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUIndexedPrimitives", ExactSpelling = true)]
        public static extern void DrawGPUIndexedPrimitives(SDL_GPURenderPass* render_pass,uint num_indices,uint num_instances,uint first_index,int vertex_offset,uint first_instance);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUPrimitives", ExactSpelling = true)]
        public static extern void DrawGPUPrimitives(SDL_GPURenderPass* render_pass,uint num_vertices,uint num_instances,uint first_vertex,uint first_instance);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUPrimitivesIndirect", ExactSpelling = true)]
        public static extern void DrawGPUPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer,uint offset,uint draw_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect", ExactSpelling = true)]
        public static extern void DrawGPUIndexedPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer,uint offset,uint draw_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPURenderPass", ExactSpelling = true)]
        public static extern void EndGPURenderPass(SDL_GPURenderPass* render_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPUComputePass", ExactSpelling = true)]
        public static extern SDL_GPUComputePass* BeginGPUComputePass(SDL_GPUCommandBuffer* command_buffer,SDL_GPUStorageTextureReadWriteBinding* storage_texture_bindings,uint num_storage_texture_bindings,SDL_GPUStorageBufferReadWriteBinding* storage_buffer_bindings,uint num_storage_buffer_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputePipeline", ExactSpelling = true)]
        public static extern void BindGPUComputePipeline(SDL_GPUComputePass* compute_pass, SDL_GPUComputePipeline* compute_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeSamplers", ExactSpelling = true)]
        public static extern void BindGPUComputeSamplers(SDL_GPUComputePass* compute_pass,uint first_slot,SDL_GPUTextureSamplerBinding* texture_sampler_bindings,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeStorageTextures", ExactSpelling = true)]
        public static extern void BindGPUComputeStorageTextures(SDL_GPUComputePass* compute_pass,uint first_slot,SDL_GPUTexture** storage_textures,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BindGPUComputeStorageBuffers", ExactSpelling = true)]
        public static extern void BindGPUComputeStorageBuffers(SDL_GPUComputePass* compute_pass,uint first_slot,SDL_GPUBuffer** storage_buffers,uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DispatchGPUCompute", ExactSpelling = true)]
        public static extern void DispatchGPUCompute(SDL_GPUComputePass* compute_pass,uint groupcount_x,uint groupcount_y,uint groupcount_z);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DispatchGPUComputeIndirect", ExactSpelling = true)]
        public static extern void DispatchGPUComputeIndirect(SDL_GPUComputePass* compute_pass, SDL_GPUBuffer* buffer,uint offset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPUComputePass", ExactSpelling = true)]
        public static extern void EndGPUComputePass(SDL_GPUComputePass* compute_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MapGPUTransferBuffer", ExactSpelling = true)]
        public static extern void* MapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer,bool8 cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnmapGPUTransferBuffer", ExactSpelling = true)]
        public static extern void UnmapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BeginGPUCopyPass", ExactSpelling = true)]
        public static extern SDL_GPUCopyPass* BeginGPUCopyPass(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UploadToGPUTexture", ExactSpelling = true)]
        public static extern void UploadToGPUTexture(SDL_GPUCopyPass* copy_pass,SDL_GPUTextureTransferInfo* source,SDL_GPUTextureRegion* destination,bool8 cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UploadToGPUBuffer", ExactSpelling = true)]
        public static extern void UploadToGPUBuffer(SDL_GPUCopyPass* copy_pass,SDL_GPUTransferBufferLocation* source,SDL_GPUBufferRegion* destination,bool8 cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyGPUTextureToTexture", ExactSpelling = true)]
        public static extern void CopyGPUTextureToTexture(SDL_GPUCopyPass* copy_pass,SDL_GPUTextureLocation* source,SDL_GPUTextureLocation* destination,uint w,uint h,uint d,bool8 cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyGPUBufferToBuffer", ExactSpelling = true)]
        public static extern void CopyGPUBufferToBuffer(SDL_GPUCopyPass* copy_pass,SDL_GPUBufferLocation* source,SDL_GPUBufferLocation* destination,uint size,bool8 cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DownloadFromGPUTexture", ExactSpelling = true)]
        public static extern void DownloadFromGPUTexture(SDL_GPUCopyPass* copy_pass,SDL_GPUTextureRegion* source,SDL_GPUTextureTransferInfo* destination);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DownloadFromGPUBuffer", ExactSpelling = true)]
        public static extern void DownloadFromGPUBuffer(SDL_GPUCopyPass* copy_pass,SDL_GPUBufferRegion* source,SDL_GPUTransferBufferLocation* destination);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EndGPUCopyPass", ExactSpelling = true)]
        public static extern void EndGPUCopyPass(SDL_GPUCopyPass* copy_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GenerateMipmapsForGPUTexture", ExactSpelling = true)]
        public static extern void GenerateMipmapsForGPUTexture(SDL_GPUCommandBuffer* command_buffer, SDL_GPUTexture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BlitGPUTexture", ExactSpelling = true)]
        public static extern void BlitGPUTexture(SDL_GPUCommandBuffer* command_buffer,SDL_GPUBlitInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition", ExactSpelling = true)]
        public static extern bool8 WindowSupportsGPUSwapchainComposition(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowSupportsGPUPresentMode", ExactSpelling = true)]
        public static extern bool8 WindowSupportsGPUPresentMode(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUPresentMode present_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClaimWindowForGPUDevice", ExactSpelling = true)]
        public static extern bool8 ClaimWindowForGPUDevice(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseWindowFromGPUDevice", ExactSpelling = true)]
        public static extern void ReleaseWindowFromGPUDevice(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUSwapchainParameters", ExactSpelling = true)]
        public static extern bool8 SetGPUSwapchainParameters(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition, SDL_GPUPresentMode present_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPUAllowedFramesInFlight", ExactSpelling = true)]
        public static extern bool8 SetGPUAllowedFramesInFlight(SDL_GPUDevice* device,uint allowed_frames_in_flight);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPUSwapchainTextureFormat", ExactSpelling = true)]
        public static extern SDL_GPUTextureFormat GetGPUSwapchainTextureFormat(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AcquireGPUSwapchainTexture", ExactSpelling = true)]
        public static extern bool8 AcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture,uint* swapchain_texture_width,uint* swapchain_texture_height);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUSwapchain", ExactSpelling = true)]
        public static extern bool8 WaitForGPUSwapchain(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture", ExactSpelling = true)]
        public static extern bool8 WaitAndAcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture,uint* swapchain_texture_width,uint* swapchain_texture_height);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SubmitGPUCommandBuffer", ExactSpelling = true)]
        public static extern bool8 SubmitGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence", ExactSpelling = true)]
        public static extern SDL_GPUFence* SubmitGPUCommandBufferAndAcquireFence(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CancelGPUCommandBuffer", ExactSpelling = true)]
        public static extern bool8 CancelGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUIdle", ExactSpelling = true)]
        public static extern bool8 WaitForGPUIdle(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitForGPUFences", ExactSpelling = true)]
        public static extern bool8 WaitForGPUFences(SDL_GPUDevice* device,bool8 wait_all,SDL_GPUFence** fences,uint num_fences);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QueryGPUFence", ExactSpelling = true)]
        public static extern bool8 QueryGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReleaseGPUFence", ExactSpelling = true)]
        public static extern void ReleaseGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureFormatTexelBlockSize", ExactSpelling = true)]
        public static extern uint GPUTextureFormatTexelBlockSize(SDL_GPUTextureFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureSupportsFormat", ExactSpelling = true)]
        public static extern bool8 GPUTextureSupportsFormat(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUTextureType type, SDL_GPUTextureUsageFlags usage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GPUTextureSupportsSampleCount", ExactSpelling = true)]
        public static extern bool8 GPUTextureSupportsSampleCount(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUSampleCount sample_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CalculateGPUTextureFormatSize", ExactSpelling = true)]
        public static extern uint CalculateGPUTextureFormatSize(SDL_GPUTextureFormat format,uint width,uint height,uint depth_or_layer_count);
    }
}
