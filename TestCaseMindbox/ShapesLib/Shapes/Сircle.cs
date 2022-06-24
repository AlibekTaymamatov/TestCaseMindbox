namespace ShapesLib
{
    using System;

    public class Сircle<T>: Shape
    {
        private T r;

        public Сircle(T radius) {
            r = radius;
        }

        public T Radius
        {
            get { return r; }
            set { r = value; }
        }

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        public override double CalculateArea()
        {
            double r = Convert.ToDouble(this.r);

            if (r < 0) 
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            }

            double s = Math.PI * (r * r);
            return s;
        }
    }
}
