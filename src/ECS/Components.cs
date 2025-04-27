using KP;

namespace KPC
{
    public class Component { }

    public class Position : Component
    {
        Vector2 Value = new Vector2();

        public Position()
        {
            Value = Vector2.Zero;
        }

        public Position(Vector2 value)
        {
            Value = value;
        }
    }

    public class Size : Component
    {
        Vector2 Value = new Vector2();

        public Size()
        {
            Value = Vector2.Zero;
        }

        public Size(Vector2 value)
        {
            Value = value;
        }
    }

    public class Color : Component
    {
        KP.Color Value = new KP.Color();

        public Color()
        {
            Value = KP.Color.White;
        }

        public Color(KP.Color Color)
        {
            Value = Color;
        }
    }
}