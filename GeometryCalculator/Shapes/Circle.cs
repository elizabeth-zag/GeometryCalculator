using System;
using GeometryCalculator.Interfaces;

namespace GeometryCalculator.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IAreaCalculator
    {
        /// <summary> Радиус </summary>
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}