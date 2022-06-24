namespace TestLib
{
    using System;
    using ShapesLib;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape circle = new Сircle<string>("10");
                Shape triangle = new Triangle<int>(2, 2, 2);

                double circleArea = circle.CalculateArea();
                double triangleArea = triangle.CalculateArea();

                Triangle<double> typeTriangle = new Triangle<double>(3, 4, 5);
                typeTriangle.CalculateArea();

                Console.WriteLine($"Площадь круга: {circleArea}");
                Console.WriteLine($"Площадь треугольника: {triangleArea}");
                Console.WriteLine($"Тип треугольника: {typeTriangle.TypeTriangle}");
                Console.ReadKey();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Console.ReadKey();
            }
        }
    }
}