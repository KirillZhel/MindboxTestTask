using System;

namespace MyLib
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.radius = value;

            }
            get { return radius; }
        }

        /// <summary>
        /// Initializes a new instance of the MyLib.Circle class
        /// </summary>
        /// <param name="r">radius of сircle</param>
        public Circle(double r)
        {
            Radius = r;
        }

        /// <summary>
        /// Calculates the area of ​​a circle 
        /// </summary>
        /// <returns>area of a circle</returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
