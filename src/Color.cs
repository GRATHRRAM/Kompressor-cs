using System.Drawing;

namespace KP
{
    public class Color
    {
        public float r { get; set; }
        public float g { get; set; }
        public float b { get; set; }
        public float a { get; set; }

        public static readonly Color Null  = new Color(0f, 0f, 0f, 0f);
        public static readonly Color Black = new Color(0f, 0f, 0f, 1f);
        public static readonly Color White = new Color(1f, 1f, 1f, 1f);

        public Color()
        {
            this.r = 1;
            this.g = 1;
            this.b = 1;
            this.a = 1;
        }

        public Color(float r, float g, float b, float a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public Color(int r, int g, int b, int a) 
        { 
            Set(r, g, b, a);
        }

        public void Set(int r, int g, int b, int a)
        {
            this.r = (float) r / 255f; 
            this.g = (float) g / 255f;
            this.b = (float) b / 255f;
            this.a = (float) a / 255f;
        }

        public void Set(float r, float g, float b, float a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public float[] Get()
        {
            float[] Colors = {r, g, b, a};
            return Colors;
        }

        public byte[] GetU8()
        {
            byte[] Colors =
            {
                (byte)(r * 255),
                (byte)(g * 255),
                (byte)(b * 255),
                (byte)(a * 255)
            };
            return Colors;
        }
    }
}
