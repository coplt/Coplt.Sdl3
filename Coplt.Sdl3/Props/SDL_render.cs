using System;

namespace Coplt.Sdl3;

public static unsafe partial class SDL
{

    public static readonly byte* Prop_Renderer_Create_Name_String = StrPtr("SDL.renderer.create.name"u8);

    public static readonly byte* Prop_Renderer_Create_Window_Pointer = StrPtr("SDL.renderer.create.window"u8);

    public static readonly byte* Prop_Renderer_Create_Surface_Pointer = StrPtr("SDL.renderer.create.surface"u8);

    public static readonly byte* Prop_Renderer_Create_Output_Colorspace_Number = StrPtr("SDL.renderer.create.output_colorspace"u8);

    public static readonly byte* Prop_Renderer_Create_Present_Vsync_Number = StrPtr("SDL.renderer.create.present_vsync"u8);

    public static readonly byte* Prop_Renderer_Create_Vulkan_Instance_Pointer = StrPtr("SDL.renderer.create.vulkan.instance"u8);

    public static readonly byte* Prop_Renderer_Create_Vulkan_Surface_Number = StrPtr("SDL.renderer.create.vulkan.surface"u8);

    public static readonly byte* Prop_Renderer_Create_Vulkan_Physical_Device_Pointer = StrPtr("SDL.renderer.create.vulkan.physical_device"u8);

    public static readonly byte* Prop_Renderer_Create_Vulkan_Device_Pointer = StrPtr("SDL.renderer.create.vulkan.device"u8);

    public static readonly byte* Prop_Renderer_Create_Vulkan_Graphics_Queue_Family_Index_Number = StrPtr("SDL.renderer.create.vulkan.graphics_queue_family_index"u8);

    public static readonly byte* Prop_Renderer_Create_Vulkan_Present_Queue_Family_Index_Number = StrPtr("SDL.renderer.create.vulkan.present_queue_family_index"u8);

    public static readonly byte* Prop_Renderer_Name_String = StrPtr("SDL.renderer.name"u8);

    public static readonly byte* Prop_Renderer_Window_Pointer = StrPtr("SDL.renderer.window"u8);

    public static readonly byte* Prop_Renderer_Surface_Pointer = StrPtr("SDL.renderer.surface"u8);

    public static readonly byte* Prop_Renderer_Vsync_Number = StrPtr("SDL.renderer.vsync"u8);

    public static readonly byte* Prop_Renderer_Max_Texture_Size_Number = StrPtr("SDL.renderer.max_texture_size"u8);

    public static readonly byte* Prop_Renderer_Texture_Formats_Pointer = StrPtr("SDL.renderer.texture_formats"u8);

    public static readonly byte* Prop_Renderer_Output_Colorspace_Number = StrPtr("SDL.renderer.output_colorspace"u8);

    public static readonly byte* Prop_Renderer_Hdr_Enabled_Boolean = StrPtr("SDL.renderer.HDR_enabled"u8);

    public static readonly byte* Prop_Renderer_Sdr_White_Point_Float = StrPtr("SDL.renderer.SDR_white_point"u8);

    public static readonly byte* Prop_Renderer_Hdr_Headroom_Float = StrPtr("SDL.renderer.HDR_headroom"u8);

    public static readonly byte* Prop_Renderer_D3d9_Device_Pointer = StrPtr("SDL.renderer.d3d9.device"u8);

    public static readonly byte* Prop_Renderer_D3d11_Device_Pointer = StrPtr("SDL.renderer.d3d11.device"u8);

    public static readonly byte* Prop_Renderer_D3d11_Swapchain_Pointer = StrPtr("SDL.renderer.d3d11.swap_chain"u8);

    public static readonly byte* Prop_Renderer_D3d12_Device_Pointer = StrPtr("SDL.renderer.d3d12.device"u8);

    public static readonly byte* Prop_Renderer_D3d12_Swapchain_Pointer = StrPtr("SDL.renderer.d3d12.swap_chain"u8);

    public static readonly byte* Prop_Renderer_D3d12_Command_Queue_Pointer = StrPtr("SDL.renderer.d3d12.command_queue"u8);

    public static readonly byte* Prop_Renderer_Vulkan_Instance_Pointer = StrPtr("SDL.renderer.vulkan.instance"u8);

    public static readonly byte* Prop_Renderer_Vulkan_Surface_Number = StrPtr("SDL.renderer.vulkan.surface"u8);

    public static readonly byte* Prop_Renderer_Vulkan_Physical_Device_Pointer = StrPtr("SDL.renderer.vulkan.physical_device"u8);

    public static readonly byte* Prop_Renderer_Vulkan_Device_Pointer = StrPtr("SDL.renderer.vulkan.device"u8);

    public static readonly byte* Prop_Renderer_Vulkan_Graphics_Queue_Family_Index_Number = StrPtr("SDL.renderer.vulkan.graphics_queue_family_index"u8);

    public static readonly byte* Prop_Renderer_Vulkan_Present_Queue_Family_Index_Number = StrPtr("SDL.renderer.vulkan.present_queue_family_index"u8);

    public static readonly byte* Prop_Renderer_Vulkan_Swapchain_Image_Count_Number = StrPtr("SDL.renderer.vulkan.swapchain_image_count"u8);

    public static readonly byte* Prop_Renderer_Gpu_Device_Pointer = StrPtr("SDL.renderer.gpu.device"u8);

    public static readonly byte* Prop_Texture_Create_Colorspace_Number = StrPtr("SDL.texture.create.colorspace"u8);

    public static readonly byte* Prop_Texture_Create_Format_Number = StrPtr("SDL.texture.create.format"u8);

    public static readonly byte* Prop_Texture_Create_Access_Number = StrPtr("SDL.texture.create.access"u8);

    public static readonly byte* Prop_Texture_Create_Width_Number = StrPtr("SDL.texture.create.width"u8);

    public static readonly byte* Prop_Texture_Create_Height_Number = StrPtr("SDL.texture.create.height"u8);

    public static readonly byte* Prop_Texture_Create_Sdr_White_Point_Float = StrPtr("SDL.texture.create.SDR_white_point"u8);

    public static readonly byte* Prop_Texture_Create_Hdr_Headroom_Float = StrPtr("SDL.texture.create.HDR_headroom"u8);

    public static readonly byte* Prop_Texture_Create_D3d11_Texture_Pointer = StrPtr("SDL.texture.create.d3d11.texture"u8);

    public static readonly byte* Prop_Texture_Create_D3d11_TextureU_Pointer = StrPtr("SDL.texture.create.d3d11.texture_u"u8);

    public static readonly byte* Prop_Texture_Create_D3d11_TextureV_Pointer = StrPtr("SDL.texture.create.d3d11.texture_v"u8);

    public static readonly byte* Prop_Texture_Create_D3d12_Texture_Pointer = StrPtr("SDL.texture.create.d3d12.texture"u8);

    public static readonly byte* Prop_Texture_Create_D3d12_TextureU_Pointer = StrPtr("SDL.texture.create.d3d12.texture_u"u8);

    public static readonly byte* Prop_Texture_Create_D3d12_TextureV_Pointer = StrPtr("SDL.texture.create.d3d12.texture_v"u8);

    public static readonly byte* Prop_Texture_Create_Metal_Pixelbuffer_Pointer = StrPtr("SDL.texture.create.metal.pixelbuffer"u8);

    public static readonly byte* Prop_Texture_Create_Opengl_Texture_Number = StrPtr("SDL.texture.create.opengl.texture"u8);

    public static readonly byte* Prop_Texture_Create_Opengl_Texture_Uv_Number = StrPtr("SDL.texture.create.opengl.texture_uv"u8);

    public static readonly byte* Prop_Texture_Create_Opengl_TextureU_Number = StrPtr("SDL.texture.create.opengl.texture_u"u8);

    public static readonly byte* Prop_Texture_Create_Opengl_TextureV_Number = StrPtr("SDL.texture.create.opengl.texture_v"u8);

    public static readonly byte* Prop_Texture_Create_Opengles2_Texture_Number = StrPtr("SDL.texture.create.opengles2.texture"u8);

    public static readonly byte* Prop_Texture_Create_Opengles2_Texture_Uv_Number = StrPtr("SDL.texture.create.opengles2.texture_uv"u8);

    public static readonly byte* Prop_Texture_Create_Opengles2_TextureU_Number = StrPtr("SDL.texture.create.opengles2.texture_u"u8);

    public static readonly byte* Prop_Texture_Create_Opengles2_TextureV_Number = StrPtr("SDL.texture.create.opengles2.texture_v"u8);

    public static readonly byte* Prop_Texture_Create_Vulkan_Texture_Number = StrPtr("SDL.texture.create.vulkan.texture"u8);

    public static readonly byte* Prop_Texture_Colorspace_Number = StrPtr("SDL.texture.colorspace"u8);

    public static readonly byte* Prop_Texture_Format_Number = StrPtr("SDL.texture.format"u8);

    public static readonly byte* Prop_Texture_Access_Number = StrPtr("SDL.texture.access"u8);

    public static readonly byte* Prop_Texture_Width_Number = StrPtr("SDL.texture.width"u8);

    public static readonly byte* Prop_Texture_Height_Number = StrPtr("SDL.texture.height"u8);

    public static readonly byte* Prop_Texture_Sdr_White_Point_Float = StrPtr("SDL.texture.SDR_white_point"u8);

    public static readonly byte* Prop_Texture_Hdr_Headroom_Float = StrPtr("SDL.texture.HDR_headroom"u8);

    public static readonly byte* Prop_Texture_D3d11_Texture_Pointer = StrPtr("SDL.texture.d3d11.texture"u8);

    public static readonly byte* Prop_Texture_D3d11_TextureU_Pointer = StrPtr("SDL.texture.d3d11.texture_u"u8);

    public static readonly byte* Prop_Texture_D3d11_TextureV_Pointer = StrPtr("SDL.texture.d3d11.texture_v"u8);

    public static readonly byte* Prop_Texture_D3d12_Texture_Pointer = StrPtr("SDL.texture.d3d12.texture"u8);

    public static readonly byte* Prop_Texture_D3d12_TextureU_Pointer = StrPtr("SDL.texture.d3d12.texture_u"u8);

    public static readonly byte* Prop_Texture_D3d12_TextureV_Pointer = StrPtr("SDL.texture.d3d12.texture_v"u8);

    public static readonly byte* Prop_Texture_Opengl_Texture_Number = StrPtr("SDL.texture.opengl.texture"u8);

    public static readonly byte* Prop_Texture_Opengl_Texture_Uv_Number = StrPtr("SDL.texture.opengl.texture_uv"u8);

    public static readonly byte* Prop_Texture_Opengl_TextureU_Number = StrPtr("SDL.texture.opengl.texture_u"u8);

    public static readonly byte* Prop_Texture_Opengl_TextureV_Number = StrPtr("SDL.texture.opengl.texture_v"u8);

    public static readonly byte* Prop_Texture_Opengl_Texture_Target_Number = StrPtr("SDL.texture.opengl.target"u8);

    public static readonly byte* Prop_Texture_Opengl_TexW_Float = StrPtr("SDL.texture.opengl.tex_w"u8);

    public static readonly byte* Prop_Texture_Opengl_TexH_Float = StrPtr("SDL.texture.opengl.tex_h"u8);

    public static readonly byte* Prop_Texture_Opengles2_Texture_Number = StrPtr("SDL.texture.opengles2.texture"u8);

    public static readonly byte* Prop_Texture_Opengles2_Texture_Uv_Number = StrPtr("SDL.texture.opengles2.texture_uv"u8);

    public static readonly byte* Prop_Texture_Opengles2_TextureU_Number = StrPtr("SDL.texture.opengles2.texture_u"u8);

    public static readonly byte* Prop_Texture_Opengles2_TextureV_Number = StrPtr("SDL.texture.opengles2.texture_v"u8);

    public static readonly byte* Prop_Texture_Opengles2_Texture_Target_Number = StrPtr("SDL.texture.opengles2.target"u8);

    public static readonly byte* Prop_Texture_Vulkan_Texture_Number = StrPtr("SDL.texture.vulkan.texture"u8);

}
