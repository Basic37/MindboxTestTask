using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Triangle : IFigure
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!TriangleSidesValidation(sideA, sideB, sideC)) throw new ArgumentException("Cумма любых двух сторон должна быть больше третьей стороны");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private bool TriangleSidesValidation(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB) > sideC && (sideB + sideC) > sideA && (sideA + sideC) > sideB;
        }

        public double SideA { get; init; } = 1.0;
        public double SideB { get; init; } = 1.0;
        public double SideC { get; init; } = 1.0;

        public double CalculatingArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool RightAngleCheck()
        {
            bool CalculatingAngle(double sideA, double sideB, double sideC)
            {
                double angle = Math.Acos((Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) / (2 * sideA * sideB));
                return ((angle * (180 / Math.PI)) == 90.0);
            }

            return CalculatingAngle(SideA, SideB, SideC) || CalculatingAngle(SideB, SideC, SideA) || CalculatingAngle(SideA, SideC, SideB);
        }

    }
}
