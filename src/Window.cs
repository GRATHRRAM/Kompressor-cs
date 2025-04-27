using SDL;

namespace KP
{
    public class Window
    {
        private unsafe readonly SDL_Window* _Window = null;
        private unsafe readonly SDL_Renderer* _Renderer = null;

        public unsafe Window(string Title, int Width, int Height, SDL_WindowFlags Flags)
        {
            _Window = SDL3.SDL_CreateWindow(Title, Width, Height, Flags);

            if (_Window == null)
            {
                Console.WriteLine("KP.Window -> Can't Create A SDL_Window!");
                return;
            }

            _Renderer = SDL3.SDL_CreateRenderer(_Window,(byte*) null);

            if (_Renderer == null)
            {
                Console.WriteLine("KP.Window -> Can't Create A SDL_Renderer!");
                SDL3.SDL_DestroyWindow(_Window);
                return;
            }
        }

        unsafe ~Window()
        {
            SDL3.SDL_DestroyRenderer(_Renderer);
            SDL3.SDL_DestroyWindow(_Window);
        }

        public unsafe SDL_Window* GetWindow()
        {
            return _Window;
        }

        public unsafe SDL_Renderer* GetRenderer()
        {
            return _Renderer;
        }
    }
}
