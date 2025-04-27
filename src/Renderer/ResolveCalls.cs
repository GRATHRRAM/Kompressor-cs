using SDL;
using KP;

namespace KP
{
    public partial class Renderer
    {
        private void ResolveCalls()
        {
            foreach (Entity _Entity in Entities)
            {
                ResolveRects(_Entity);
            }
        }

        private unsafe void ResolveRects(Entity _Entity)
        {
            if (!_Entity.HasComponent<KPC.Position>() || !_Entity.HasComponent<KPC.Size>()) return;

            KPC.Position Position = _Entity.GetComponent<KPC.Position>();
            KPC.Size Size = _Entity.GetComponent<KPC.Size>();

            KPC.Color Color = new KPC.Color();

            if (_Entity.HasComponent<KPC.Color>()) Color = _Entity.GetComponent<KPC.Color>();

            SDL_FRect Rect = new SDL_FRect();
            Rect.x = Position.x;
            Rect.y = Position.y;
            Rect.w = Size.w;
            Rect.h = Size.h;

            byte[] Colors = Color.GetU8();
            SDL3.SDL_SetRenderDrawColor(_Window.GetRenderer(), Colors[0], Colors[1], Colors[2], Colors[3]);
            SDL3.SDL_RenderFillRect(_Window.GetRenderer(), &Rect);
        }
    }
}
