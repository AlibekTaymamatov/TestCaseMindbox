using System;
using Xunit;
using ShapesLib;

namespace TestMindbox
{
    public class TriangleTest
    {
        /// <summary>
        /// Тестируем тип прямоугольный
        /// </summary>
        [Fact]
        public void TriangleTypeRectangularTest()
        {
            //Arrange
            Triangle<double> triangle = new Triangle<double>(3, 4, 5);
            //Act
            triangle.CalculateArea();
            string typeTriangle = triangle.TypeTriangle;
            //Assert
            Assert.Equal("Треугольник прямоугольный", typeTriangle);
        }

        /// <summary>
        /// Тестируем вычисление площади треугольника
        /// </summary>
        [Fact]
        public void TriangleCalculateAreaTest()
        {
            //Arrange
            Triangle<double> triangle = new Triangle<double>(2, 3, 4);
            //Act
            double triangleArea = triangle.CalculateArea();
            //Assert
            Assert.Equal(2.9047375096555625, triangleArea);
        }

        /// <summary>
        /// Тестируем отрицательные сторону треугольника
        /// </summary>
        [Fact]
        public void TriangleNegativeSidesTest()
        {
            //Arrange
            Triangle<int> triangle = new Triangle<int>(-3, 4, 5);
            //Act
            var expectedException = new ArgumentOutOfRangeException("Треугольник не существует");
            var thrownException = Assert.Throws<ArgumentOutOfRangeException>(() => triangle.CalculateArea());
            //Assert
            Assert.Equal(expectedException.Message, thrownException.Message);
        }

        /// <summary>
        /// Тестируем тип тупоугольный
        /// </summary>
        [Fact]
        public void TriangleTypeTest()
        {
            //Arrange
            Triangle<double> triangle = new Triangle<double>(2, 3, 4);
            //Act
            triangle.CalculateArea();
            string typeTriangle = triangle.TypeTriangle;
            //Assert
            Assert.Equal("Треугольник тупоугольный", typeTriangle);
        }

        /// <summary>
        /// Тестируем тип остроугольный
        /// </summary>
        [Fact]
        public void TriangleTypeSharpTest()
        {
            //Arrange
            Triangle<double> triangle = new Triangle<double>(2, 2, 2);
            //Act
            triangle.CalculateArea();
            string typeTriangle = triangle.TypeTriangle;
            //Assert
            Assert.Equal("Треугольник остроугольный", typeTriangle);
        }
    }
}
