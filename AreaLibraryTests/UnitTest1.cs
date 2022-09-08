using System;
using AreaLibrary;

namespace AreaLibraryTests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculatingСircleArea()
        {
            //Arrange
            double eps = 0.00001;
            double radius = 1;
            IFigure figure = new Circle(radius);

            //Act
            double area = figure.CalculatingArea();

            //Assert
            Assert.True(Math.Abs(area - 3.1415926535897931) < eps);
        }

        [Fact]
        public void CalculatingTriangleArea()
        {
            //Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            IFigure figure = new Triangle(sideA, sideB, sideC);

            //Act
            double area = figure.CalculatingArea();

            //Assert
            Assert.Equal(6.0, area);
        }

        [Fact]
        public void TriangleSidesValidation()
        {
            //Arrange
            double sideA = 3.0;
            double sideB = 1.0;
            double sideC = 5.0;

            //Act
            Action act = () => new Triangle(sideA, sideB, sideC);

            //Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Cумма любых двух сторон должна быть больше третьей стороны", exception.Message);
        }

        [Theory]
        [InlineData(3.0, 4.0, 5.0, true)]
        [InlineData(3.0, 4.0, 6.0, false)]
        public void RightAngleCheck(double sideA, double sideB, double sideC, bool expected)
        {
            //Arrange
            Triangle figure = new Triangle(sideA, sideB, sideC);

            //Act
            bool RightAngle = figure.RightAngleCheck();

            //Assert
            Assert.Equal(expected, RightAngle);
        }
    }
}