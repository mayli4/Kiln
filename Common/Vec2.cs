namespace Kiln.Common {
    public class Vec2 {

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
    }
}
