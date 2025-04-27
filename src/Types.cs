namespace KP
{
    public class Vector2
    {
        public Vector2() { this.x = 0; this.y = 0; }
        public Vector2(float x, float y) { this.x = x; this.y = y; }
        public float x { get; set; }
        public float y { get; set; }
        public static readonly Vector2 Zero = new Vector2(0, 0);
    }

    public class Rect
    {
        public Rect() { this.x = 0; this.y = 0; this.w = 0; this.h = 0; }
        public Rect(float x, float y, float w, float h) { this.x = x; this.y = y; this.w = w; this.h = h; }
        public float x { get; set; }
        public float y { get; set; }
        public float w { get; set; }
        public float h { get; set; }
    }

    public class Line
    {
        public Line() { this.x = 0; this.y = 0; this.x2 = 0; this.y2 = 0; }
        public Line(float x, float y, float x2, float y2) { this.x = x; this.y = y; this.x2 = x2; this.y2 = y2; }
        public float x { get; set; }
        public float y { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }
    }
}
