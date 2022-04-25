using NetTopologySuite.Geometries;
using System;

namespace Peliculas.Data.Geometry
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point a, Point b)
        {
            if (a == null || b == null) throw new ArgumentException("Provide both points to calculate the distance");
            return a.Distance(b);
        }
    }
}
