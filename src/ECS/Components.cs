using KP;

namespace KPC
{
    public class Component { }

    public class Position : Component
    {
         private Vector2 _Vector;

        public float x
        {
            get => _Vector.x;
            set => _Vector.x = value;
        }

        public float y
        {
            get => _Vector.y;
            set => _Vector.y = value;
        }

        public Position()
        {
            _Vector = Vector2.Zero;
        }

        public Position(Vector2 value)
        {
            _Vector = value;
        }
    }

    public class Size : Component
    {
        private Vector2 _Vector;

        public float w
        {
            get => _Vector.x;
            set => _Vector.x = value;
        }

        public float h
        {
            get => _Vector.y;
            set => _Vector.y = value;
        }

        public Size()
        {
            _Vector = Vector2.Zero;
        }

        public Size(Vector2 value)
        {
            _Vector = value;
        }
    }

    public class Color : Component
    {
        public KP.Color ColorClass = new KP.Color();

        public Color()
        {
            ColorClass = KP.Color.White;
        }

        public Color(KP.Color Color)
        {
            ColorClass = Color;
        }

        public float r { get => ColorClass.r; set => ColorClass.r = value; }
        public float g { get => ColorClass.g; set => ColorClass.g = value; }
        public float b { get => ColorClass.b; set => ColorClass.b = value; }
        public float a { get => ColorClass.a; set => ColorClass.a = value; }

        public byte[] GetU8() {return ColorClass.GetU8();}
    }
}