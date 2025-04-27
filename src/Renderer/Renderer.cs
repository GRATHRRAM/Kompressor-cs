using System.Numerics;
using SDL;
using KP;

namespace KP
{
    public partial class Renderer
    {
        private List<Entity> Entities = new();
        private Window _Window;

        public Renderer(Window _Window) { this._Window = _Window; }

        //TODO CAMERA2D

        public unsafe void Clear(Color _Color)
        {
            byte[] Colors = _Color.GetU8();
            SDL3.SDL_SetRenderDrawColor(_Window.GetRenderer(), Colors[0], Colors[1], Colors[2], Colors[3]);
            SDL3.SDL_RenderClear(_Window.GetRenderer());
        }

        public unsafe void Present()
        {
            Entities.Sort((a, b) => a.ZIndex.CompareTo(b.ZIndex));
            ResolveCalls();
            SDL3.SDL_RenderPresent(_Window.GetRenderer());
            Entities.Clear();
        }

        public void DrawEntity(Entity _Entity)
        {
            Entities.Add(_Entity);
        }
        
        public void DrawRect(Rect _Rect, Color _Color, UInt32 ZIndex = 0)
        {
            Entity _Entity = new Entity(0, ZIndex, "Entity");
            _Entity.AddComponent<KPC.Position>(new Vector2(_Rect.x, _Rect.y));
            _Entity.AddComponent<KPC.Size>(new Vector2(_Rect.w, _Rect.h));
            _Entity.AddComponent<KPC.Color>(_Color);

            Entities.Add(_Entity);
        }
    }
}
