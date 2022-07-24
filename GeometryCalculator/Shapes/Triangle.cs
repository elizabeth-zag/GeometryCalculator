using System;
using GeometryCalculator.Interfaces;

namespace GeometryCalculator.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IAreaCalculator
    {
        /// <summary> Сторона А </summary>
        public double A { get; }
        /// <summary> Сторона Б </summary>
        public double B { get; }
        /// <summary> Сторона С </summary>
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    
        public double CalculateArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsOrthogonal()
        {
            var sides = new [] {A, B, C};
            Array.Sort(sides);
        
            return Math.Abs((Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) - Math.Pow(sides[2], 2)) < double.Epsilon;
        }
    }
}