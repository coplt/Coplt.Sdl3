using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Coplt.Sdl3;

namespace Test2;

unsafe class Program
{
    private static bool run = true;

    [STAThread]
    static void Main(string[] args)
    {
        if (!SDL.Init(SDL_InitFlags.Video)) throw new SdlException();

        SDL_Window* window;
        window = SDL.CreateWindow(SDL.StrPtr("Test"u8), 960, 540, SDL_WindowFlags.Resizable);
        if (window == null) throw new SdlException();
        
        var device_prop = SDL.CreateProperties();

        var gpu_debug = true;
        var shader_format = SDL_GPUShaderFormat.Dxil;
        var shader_suffix = "dxil";
        if (args.Contains("--vk") || !RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            shader_format = SDL_GPUShaderFormat.Spirv;
            shader_suffix = "spv";
            SDL.SetBooleanProperty(device_prop, SDL.StrPtr("SDL.gpu.device.create.shaders.spirv"u8), true);
            SDL.SetBooleanProperty(device_prop, SDL.StrPtr("SDL.gpu.device.create.debugmode"u8), gpu_debug);
            SDL.SetStringProperty(device_prop, SDL.StrPtr("SDL.gpu.device.create.name"u8), null);
        }
        else
        {
            shader_format = SDL_GPUShaderFormat.Dxil;
            shader_suffix = "dxil";
            SDL.SetBooleanProperty(device_prop, SDL.StrPtr("SDL.gpu.device.create.shaders.dxil"u8), true);
            SDL.SetBooleanProperty(device_prop, SDL.StrPtr("SDL.gpu.device.create.debugmode"u8), gpu_debug);
            SDL.SetStringProperty(device_prop, SDL.StrPtr("SDL.gpu.device.create.name"u8), null);
            SDL.SetStringProperty(device_prop, SDL.StrPtr("SDL.gpu.device.create.d3d12.semantic"u8), SDL.StrPtr("POSITION"u8));
        }
        var device = SDL.CreateGPUDeviceWithProperties(device_prop);
        if (device == null) throw new SdlException();

        if (!SDL.ClaimWindowForGPUDevice(device, window)) throw new SdlException();

        SDL_GPUShader* shader_vertex;
        SDL_GPUShader* pixel_vertex;
        var blob_vertex = File.ReadAllBytes(Path.Join(AppContext.BaseDirectory, $"Shader.Vertex.{shader_suffix}"));
        var blob_pixel = File.ReadAllBytes(Path.Join(AppContext.BaseDirectory, $"Shader.Pixel.{shader_suffix}"));
        fixed (byte* p_blob_vertex = blob_vertex)
        {
            SDL_GPUShaderCreateInfo shader_info = new()
            {
                code_size = (nuint)blob_vertex.Length,
                code = p_blob_vertex,
                entrypoint = SDL.StrPtr("Vertex"u8),
                format = shader_format,
                stage = SDL_GPUShaderStage.Vertex,
            };
            shader_vertex = SDL.CreateGPUShader(device, &shader_info);
            if (shader_vertex == null) throw new SdlException();
        }
        fixed (byte* p_blob_pixel = blob_pixel)
        {
            SDL_GPUShaderCreateInfo shader_info = new()
            {
                code_size = (nuint)blob_pixel.Length,
                code = p_blob_pixel,
                entrypoint = SDL.StrPtr("Pixel"u8),
                format = shader_format,
                stage = SDL_GPUShaderStage.Fragment,
            };
            pixel_vertex = SDL.CreateGPUShader(device, &shader_info);
            if (pixel_vertex == null) throw new SdlException();
        }

        SDL_GPUColorTargetDescription color_target_description = new()
        {
            format = SDL.GetGPUSwapchainTextureFormat(device, window),
            blend_state = new()
            {
                src_color_blendfactor = SDL_GPUBlendFactor.SrcAlpha,
                dst_color_blendfactor = SDL_GPUBlendFactor.OneMinusSrcAlpha,
                color_blend_op = SDL_GPUBlendOp.Add,
                src_alpha_blendfactor = SDL_GPUBlendFactor.One,
                dst_alpha_blendfactor = SDL_GPUBlendFactor.One,
                alpha_blend_op = SDL_GPUBlendOp.Max,
                enable_blend = true,
            }
        };
        var vertex_buffer_descriptions = stackalloc SDL_GPUVertexBufferDescription[2]
        {
            new()
            {
                slot = 0,
                pitch = sizeof(float) * 7
            },
            new()
            {
                slot = 1,
                pitch = sizeof(float) * 2
            }
        };
        var vertex_attributes = stackalloc SDL_GPUVertexAttribute[3]
        {
            new()
            {
                location = 0,
                buffer_slot = 0,
                format = SDL_GPUVertexElementFormat.Float3,
                offset = 0
            },
            new()
            {
                location = 1,
                buffer_slot = 0,
                format = SDL_GPUVertexElementFormat.Float4,
                offset = sizeof(float) * 3
            },
            new()
            {
                location = 2,
                buffer_slot = 1,
                format = SDL_GPUVertexElementFormat.Float2,
                offset = 0
            }
        };
        SDL_GPUGraphicsPipelineCreateInfo pipeline_info = new()
        {
            vertex_shader = shader_vertex,
            fragment_shader = pixel_vertex,
            vertex_input_state = new()
            {
                vertex_buffer_descriptions = vertex_buffer_descriptions,
                num_vertex_buffers = 2,
                vertex_attributes = vertex_attributes,
                num_vertex_attributes = 3
            },
            target_info = new()
            {
                color_target_descriptions = &color_target_description,
                num_color_targets = 1,
            }
        };
        var pipeline = SDL.CreateGPUGraphicsPipeline(device, &pipeline_info);
        if (pipeline == null) throw new SdlException();

        SDL_GPUBufferCreateInfo buffer_info = new()
        {
            usage = SDL_GPUBufferUsageFlags.Vertex,
            size = sizeof(float) * 7 * 3,
        };
        var pc_buffer = SDL.CreateGPUBuffer(device, &buffer_info);
        if (pc_buffer == null) throw new SdlException();
        buffer_info = new()
        {
            usage = SDL_GPUBufferUsageFlags.Vertex,
            size = sizeof(float) * 2 * 3,
        };
        var uv_buffer = SDL.CreateGPUBuffer(device, &buffer_info);
        if (uv_buffer == null) throw new SdlException();

        SDL_GPUTransferBufferCreateInfo t_buffer_info = new()
        {
            usage = SDL_GPUTransferBufferUsage.Upload,
            size = 1024
        };
        var t_buffer = SDL.CreateGPUTransferBuffer(device, &t_buffer_info);
        if (t_buffer == null) throw new SdlException();
        var transfer = new Span<byte>(SDL.MapGPUTransferBuffer(device, t_buffer, true), 1024);
        MemoryMarshal.AsBytes([
            /* position */ 0.0f, 0.5f * 1.7f, 0f, /* color */ 0.71f, 0.22f, 0.21f, 1f,
            /* position */ 0.5f, -0.5f * 1.7f, 0f, /* color */ 0.34f, 0.64f, 0.31f, 1f,
            /* position */ -0.5f, -0.5f * 1.7f, 0f, /* color */ 0.36f, 0.42f, 0.92f, 1f,
            // uv
            0.0f, 0.0f,
            -1.0f, 2.0f,
            1.0f, 2.0f,
        ]).CopyTo(transfer);
        SDL.UnmapGPUTransferBuffer(device, t_buffer);

        {
            var cmd = SDL.AcquireGPUCommandBuffer(device);
            var pass = SDL.BeginGPUCopyPass(cmd);
            if (pass == null) throw new SdlException();
            SDL_GPUTransferBufferLocation location = new() { transfer_buffer = t_buffer, offset = 0 };
            SDL_GPUBufferRegion region = new() { buffer = pc_buffer, offset = 0, size = sizeof(float) * 7 * 3 };
            SDL.UploadToGPUBuffer(pass, &location, &region, true);
            location = new() { transfer_buffer = t_buffer, offset = sizeof(float) * 7 * 3 };
            region = new() { buffer = uv_buffer, offset = 0, size = sizeof(float) * 2 * 3 };
            SDL.UploadToGPUBuffer(pass, &location, &region, true);
            SDL.EndGPUCopyPass(pass);
            SDL.SubmitGPUCommandBuffer(cmd);
        }

        SDL.ReleaseGPUTransferBuffer(device, t_buffer);

        var render_thread = new Thread(() =>
        {
            var bindings = stackalloc SDL_GPUBufferBinding[2];
            try
            {
                while (run)
                {
                    var cmd = SDL.AcquireGPUCommandBuffer(device);
                    uint width, height;
                    SDL_GPUTexture* output;
                    if (!SDL.WaitAndAcquireGPUSwapchainTexture(cmd, window, &output, &width, &height))
                        throw new SdlException();
                    SDL_GPUColorTargetInfo pass_info = new()
                    {
                        texture = output,
                        clear_color = new() { r = 0.83f, g = 0.8f, b = 0.97f, a = 1 },
                        load_op = SDL_GPULoadOp.Clear,
                        store_op = SDL_GPUStoreOp.Store,
                    };
                    var pass = SDL.BeginGPURenderPass(cmd, &pass_info, 1, null);
                    if (pass == null) throw new SdlException();
                    SDL.BindGPUGraphicsPipeline(pass, pipeline);
                    SDL_GPUViewport viewport = new() { w = width, h = height, min_depth = 0, max_depth = 1 };
                    SDL.SetGPUViewport(pass, &viewport);
                    bindings[0] = new() { buffer = pc_buffer, offset = 0 };
                    bindings[1] = new() { buffer = uv_buffer, offset = 0 };
                    SDL.BindGPUVertexBuffers(pass, 0, bindings, 2);
                    SDL.DrawGPUPrimitives(pass, 3, 1, 0, 0);
                    SDL.EndGPURenderPass(pass);
                    SDL.SubmitGPUCommandBuffer(cmd);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Environment.Exit(-1);
            }
        });
        render_thread.Start();

        while (run)
        {
            SDL_Event e;
            if (SDL.WaitEvent(&e))
            {
                if (e.Type == SDL_EventType.Quit)
                {
                    run = false;
                }
            }
        }

        render_thread.Join();
        
        SDL.ReleaseGPUBuffer(device, uv_buffer);
        SDL.ReleaseGPUBuffer(device, pc_buffer);
        SDL.ReleaseGPUGraphicsPipeline(device, pipeline);
        SDL.ReleaseGPUShader(device, shader_vertex);
        SDL.ReleaseGPUShader(device, pixel_vertex);
        SDL.DestroyGPUDevice(device);
        SDL.DestroyProperties(device_prop);
        SDL.DestroyWindow(window);

        SDL.Quit();
    }
}
