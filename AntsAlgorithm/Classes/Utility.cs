using System;
using System.Collections.Generic;
using System.Drawing;

namespace AntsAlgorithm.Classes
{
    class Utility
    {
        public static bool InsideCircle(int xc, int yc, int r, int x, int y)
        {
            int dx = xc - x;
            int dy = yc - y;
            return dx * dx + dy * dy <= r * r;
        }

        public static double DistanceInStraightLineBetweenPoints(Point point1, Point point2)
        {
            var a = (double)(point2.X - point1.X);
            var b = (double)(point2.Y - point1.Y);

            return Math.Sqrt(a * a + b * b);
        }

        public static IList<Tuple<Double, Double>> SplitLine( Tuple<Double, Double> a, Tuple<Double, Double> b, int count)
        {
            count++;

            Double d = Math.Sqrt((a.Item1 - b.Item1) * (a.Item1 - b.Item1) + (a.Item2 - b.Item2) * (a.Item2 - b.Item2)) / count;
            Double fi = Math.Atan2(b.Item2 - a.Item2, b.Item1 - a.Item1);

            List<Tuple<Double, Double>> points = new List<Tuple<Double, Double>>(count + 1);

            for (int i = 0; i <= count; ++i)
                points.Add(new Tuple<Double, Double>(a.Item1 + i * d * Math.Cos(fi), a.Item2 + i * d * Math.Sin(fi)));

            return points;
        }

    }
}
