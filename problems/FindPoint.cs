using System;

namespace ProblemSolving
{
    class FindPoint : problem
    {
        private class Point
        {
            private int _x;
            private int _y;

            public Point(int xcord, int ycord)
            {
                _x = xcord;
                _y = ycord;
            }

            public int x
            {
                get { return _x; }
            }
            public int y
            {
                get { return _y; }
            }

        }

        private double area(Point[] triangle)
        {
            return
                Math.Abs(0.5 *
                         ((triangle[1].x - triangle[0].x) * (triangle[2].y - triangle[0].y) -
                          (triangle[2].x - triangle[0].x) * (triangle[1].y - triangle[0].y)));
        }

        private bool compute(Point[] triangle, Point point)
        {
            var areaOfTriangle = area(triangle);

            var areaOfSubTriangle1 = area(new[] { triangle[0], triangle[1], point });
            var areaOfSubTriangle2 = area(new[] { triangle[0], point, triangle[2] });
            var areaOfSubTriangle3 = area(new[] { point, triangle[1], triangle[2] });


            if (areaOfSubTriangle1 + areaOfSubTriangle2 + areaOfSubTriangle3 == areaOfTriangle)
                return true;
            return false;
        }

        public bool Solution()
        {
            var fp = new FindPoint();

            var p1 = new Point(0, 0);
            var p2 = new Point(0, 4);
            var p3 = new Point(5, 0);
            Point[] triangle = { p1, p2, p3 };

            var newp = new Point(2, 1);


            var res = fp.compute(new[] { p1, p2, p3 }, newp);

            System.Console.Write(res ? "Point lies within the triangle" : "Point is outside the triangle");


            return true;

        }
    }
}
