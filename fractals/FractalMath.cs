using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractals
{
    static class FractalMath
    {
        private static Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        private static Point prevPoint;
        public static double multiplier = 0.5;
        public struct Point
        {
            public int x, y;

            public Point(int X,int Y)
            {
                x = X;
                y = Y;
            }

        }
        public static List<Point> points = new List<Point>();

        public static void HandPoint(int x, int y)
        {
            Point newPoint = new Point(x, y);
            points.Add(newPoint);
            if (points.Count < 2)
            {
                prevPoint = points[0];
            }
            Drawer.DrawInitialPoint(x, y);
        }
        public static Point GetMiddlePoint(Point firstPoint, Point lastPoint)
        {
            Point outPoint = new Point();
            outPoint.x = (int)(Math.Abs(firstPoint.x - lastPoint.x) * multiplier + GetLessNum(firstPoint.x, lastPoint.x));
            outPoint.y = (int)(Math.Abs(firstPoint.y - lastPoint.y) * multiplier + GetLessNum(firstPoint.y, lastPoint.y));
            return outPoint;
        }
        public static int GetLessNum(int first, int second)
        {
            if (first > second)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
        public static Point GetNextPoint()
        {
            int nextInitialPoint = random.Next(0, points.Count);
            Point nextPoint = GetMiddlePoint(prevPoint, points[nextInitialPoint]);
            prevPoint = nextPoint;
            return nextPoint;
        }
        public static void ClearInitialPoints()
        {
            points.Clear();
        }
    }
}
