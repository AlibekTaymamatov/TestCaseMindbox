namespace ShapesLib
{
    using System;

    public class Triangle<T>: Shape
    {
        public string TypeTriangle;

        private T a, b, c;

        public Triangle(T _a, T _b, T _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        public T Side_A
        {
            get { return a; }
            set { a = value; }
        }

        public T Side_B
        {
            get { return b; }
            set { b = value; }
        }

        public T Side_C
        {
            get { return c; }
            set { c = value; }
        }

        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        public override double CalculateArea() {

            double a = Convert.ToDouble(this.a);
            double b = Convert.ToDouble(this.b);
            double c = Convert.ToDouble(this.c);

            double alfa, beta, gamma, p, s;

            if (a + b > c && a + c > b && b + c > a) // возможно нужно было делать проверку на каждую сторону и выводить ошибку отдельно
            {
                p = (a + b + c) / 2; 

                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 

                alfa = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
                beta = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
                gamma = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;

                if (alfa > 90 || beta > 90 || gamma > 90)
                {
                    TypeTriangle = "Треугольник тупоугольный";
                }

                if (alfa == 90 || beta == 90 || gamma == 90)
                {
                    TypeTriangle = "Треугольник прямоугольный";
                }

                if (alfa < 90 & beta < 90 & gamma < 90)
                {
                    TypeTriangle = "Треугольник остроугольный";
                }
            } else {

                throw new ArgumentOutOfRangeException("Треугольник не существует");
            }

            return s;
        }
    }
}
