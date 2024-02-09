namespace Kiln.Common {
    public struct Point3 {
        int X;
        int Y;
        int Z;

        public Point3(int x, int y, int z) {
            X = x;
            Y = y;
            Z = z;
        }

        public Point2 ToPoint2() { 
            return new Point2(X, Y);
        }
    }
}
