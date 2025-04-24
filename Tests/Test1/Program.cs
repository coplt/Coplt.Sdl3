using System.Runtime.InteropServices;
using Coplt.Sdl3;

namespace Test1;

unsafe class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        if (!SDL.Init(SDL_InitFlags.Video)) throw new Exception("Init failed");

        SDL_Window* window;
        SDL_Renderer* renderer;
        fixed (byte* p_name = "Test"u8)
        {
            if (!SDL.CreateWindowAndRenderer(p_name, 960, 540, SDL_WindowFlags.Resizable, &window, &renderer))
                throw new Exception(new string((sbyte*)SDL.GetError()));
        }

        var run = true;
        while (run)
        {
            SDL_Event e;
            if (SDL.PollEvent(&e))
            {
                if (e.Type == SDL_EventType.Quit)
                {
                    run = false;
                }
            }

            SDL.SetRenderDrawColorFloat(renderer, 0.83f, 0.8f, 0.97f, 1);
            SDL.RenderClear(renderer);
            SDL.SetRenderDrawColorFloat(renderer, 1, 1, 1, 1);
            SDL_FRect rect = new() { x = 10, y = 10, w = 100, h = 100 };
            SDL.RenderFillRect(renderer, &rect);
            SDL.SetRenderDrawColorFloat(renderer, 0, 0, 0, 1);
            fixed (byte* p_text = "Test"u8)
                SDL.RenderDebugText(renderer, 120, 120, p_text);
            SDL.RenderPresent(renderer);
        }

        SDL.DestroyRenderer(renderer);
        SDL.DestroyWindow(window);

        SDL.Quit();
    }
}
