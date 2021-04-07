﻿using System;
using System.Collections.Generic;

namespace GetNeighbors
{
    public static class CartesianCoordinates
    {
        /// <summary>
        /// Gets from a set of points only points that are h-neighbors for a point with integer coordinates x and y.
        /// </summary>
        /// <param name="point">Given point with integer coordinates x and y.</param>
        /// <param name="h">Distance around a given point.</param>
        /// <param name="points">A given set of points.</param>
        /// <returns>Only points that are h-neighbors for a point with integer coordinates x and y.</returns>
        /// <exception cref="ArgumentNullException">Throw when array points is null.</exception>
        /// <exception cref="ArgumentException">Throw when h-distance is less or equals zero.</exception>
        public static Point[] GetNeighbors(Point point, int h, params Point[] points)
        {
            if (points is null)
            {
                throw new ArgumentNullException($"{nameof(points)} is null.");
            }

            if (h < 1)
            {
                throw new ArgumentException("h-distance is less or equals zero.");
            }

            List<Point> newPoints = new List<Point>();

            foreach (Point p in points)
            {
                if (Math.Abs(p.X - point.X) <= h && Math.Abs(p.Y - point.Y) <= h)
                {
                    newPoints.Add(p);
                }
            }

            return newPoints.ToArray();
        }
    }
}
