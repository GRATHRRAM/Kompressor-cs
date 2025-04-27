using System.Numerics;
using SDL;
using KP;

namespace KP
{
    public partial class Renderer
    {
        private List<Entity> Entities = new();
        private Vector<Entity> TempEntitys = new();

        //TODO CAMERA2D

        public void DrawEntity(Entity _Entity)
        {
            Entities.Add(_Entity);
        }
        
        public void DrawRect(Rect _Rect, Color _Color, UInt32 ZIndex = 0)
        {
            Entity _Entity = new Entity();
            _Entity.AddComponent<KPC.Position>(new Vector2(100, 200));
            _Entity.AddComponent<KPC.Size>(new Vector2(100, 200));
            _Entity.AddComponent<KPC.Position>(new Vector2(100, 200));
        }
    }
}
