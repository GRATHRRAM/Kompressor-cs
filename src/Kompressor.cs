using System;
using SDL;
using KP;

namespace KP {
    class Engine
    {
        private Window CurrentWindow;

        unsafe public Engine(string Title, int Width, int Height, SDL_WindowFlags Flags)
        {
            Console.WriteLine("Kompressor-cs 0.1.0");
            if (!SDL3.SDL_Init(SDL_InitFlags.SDL_INIT_VIDEO))
            {
                Console.WriteLine("Kompressor-cs -> Panic!!! Can't Init SDL3!");
                return;
            }

            CurrentWindow = new Window(Title, Width, Height, Flags);
        }

        public Window GetWindow()
        {
            return CurrentWindow;
        }
    }
}