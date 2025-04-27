using System;
using SDL;

namespace KP {
    class Engine
    {
        unsafe SDL_Window *CurrentWindow = null;

        unsafe public Engine(string Title, int Width, int Height, SDL_WindowFlags Flags)
        {
            Console.WriteLine("Kompressor-cs 0.1.0");
            if (!SDL3.SDL_Init(SDL_InitFlags.SDL_INIT_VIDEO))
            {
                Console.WriteLine("Kompressor-cs -> Panic!!! Can't Init SDL3!");
                return;
            }

            CurrentWindow = SDL3.SDL_CreateWindow(Title, Width, Height, Flags);
        }
    }
}