using SDL;
using KP;

class MainClass
{
    static unsafe void Main(string[] args)
    {
        Engine _Engine = new Engine("Demo", 1200, 720, SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE);
        Renderer _Renderer = new Renderer(_Engine.GetWindow());

        SDL_Event Event;
        bool Run = true;
        while (Run)
        {
            while (SDL3.SDL_PollEvent(&Event))
            {
                if(Event.Type == SDL_EventType.SDL_EVENT_QUIT) Run = false; break;
            }

            _Renderer.Clear(Color.Black);
            _Renderer.DrawRect(new Rect(100, 100, 100, 100), new Color(0f, 0f, 0.5f, 0f));
            _Renderer.Present();
        }
    }
}