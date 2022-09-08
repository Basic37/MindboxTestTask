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
            Radius = radius;
        }

        public double Radius { get; init; } = 1.0;

        public double CalculatingArea()
        {
            return Math.PI * Math.Pow(Radius, 2); 
        }
    }
}
