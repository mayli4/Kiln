namespace Kiln.Common {
    public struct Vec2 : IEquatable<Vec2> {

        public int X;
        public int Y;
        public static Vec2 Zero = new(0, 0);

        public Vec2(int x, int y) {
            X = x;
            Y = y;
        }

        public Vec2(float x, float y) {
            X = (int)x;
            Y = (int)y;
        }

        public bool Equals(Vec2 other) {
            return (X == other.X) && (Y == other.Y);
        }
    }
}
