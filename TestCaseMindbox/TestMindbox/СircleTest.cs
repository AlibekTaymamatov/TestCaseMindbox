using System;
using Xunit;
using ShapesLib;

namespace TestMindbox
{
    public class СircleTest
    {
        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [Fact]
        public void CircleCalculateAreaTest()
        {
            //Arrange
            Сircle<double> circle = new Сircle<double>(10);
            //Act
            double circleArea = circle.CalculateArea();
            //Assert
            Assert.Equal(314.1592653589793, circleArea);
        }

        /// <summary>
        /// Тестируем отрицательный радиус круга
        /// </summary>
        [Fact]
        public void CircleNegativeRadiusTest()
        {
            //Arrange
            Сircle<int> circle = new Сircle<int>(-5);
            //Act
            var expectedException = new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            var thrownException = Assert.Throws<ArgumentOutOfRangeException>(() => circle.CalculateArea());
            //Assert
            Assert.Equal(expectedException.Message, thrownException.Message);
        }
    }
}
