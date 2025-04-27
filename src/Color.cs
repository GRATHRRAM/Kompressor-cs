namespace KP
{
    public class Color
    {
        public float r { get; set; }
        public float g { get; set; }
        public float b { get; set; }
        public float a { get; set; }

        void Set(int r, int g, int b, int a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

    }
}
