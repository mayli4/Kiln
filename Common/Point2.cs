namespace Kiln.Common {
    public struct Point2 {
        int X;
        int Y;
        public Point2(int x, int y) {
            X = x;
            Y = y;
        }

        public Point3 ToPoint3() {
            return new Point3(X,Y,0);
        }

        public Vec2 ToVec2() {
            return new Vec2(X,Y);
        }

    }
}
