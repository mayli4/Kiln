namespace Kiln.Common {
    public struct RectF : IEquatable<RectF> {

        public int X;
        public int Y;
        public int Width;
        public int Height;

        public RectF(int x, int y, int width, int height) {
            X = x;
            Y = y;
            Width = width; 
            Height = height;
        }

        public static RectF EmptyRectangle => new RectF();

        public bool Equals(RectF other) {
            return false;
        }
    }
}
