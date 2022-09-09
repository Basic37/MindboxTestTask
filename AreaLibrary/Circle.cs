using AreaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibraryTests
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            if (!RadiusValueVerification(radius)) throw new ArgumentException("Радиус должен быть положительным");
            Radius = radius;
        }

        private bool RadiusValueVerification(double radius)
        {
            return (radius > 0);
        }

        public double Radius { get; init; } = 1.0;

        public double CalculatingArea()
        {
            return Math.PI * Math.Pow(Radius, 2); 
        }
    }
}
