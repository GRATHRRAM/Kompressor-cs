using SDL;

class MainClass
{
    static void Main(string[] args)
    {
        KP.Engine Engine = new KP.Engine("Demo", 1200, 720, SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE);

        SDL_Event Event;
        bool Run = true;
        while (Run)
        {
            unsafe
            {
                while (SDL3.SDL_PollEvent(&Event))
                {
                    if(Event.Type == SDL_EventType.SDL_EVENT_QUIT) Run = false; break;
                }
            }
        }
    }
}