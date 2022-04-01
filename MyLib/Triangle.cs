using System;

namespace MyLib
{
    public class Triangle : Figure
    {
        public double P { get; set; }
        private double[] edges;
        public double[] Edges {
            set
            {
                foreach (var edge in value)
                    if (edge <= 0) throw new ArgumentException();

                if (!(value[0] < value[1] + value[2] &&
                      value[1] < value[2] + value[0] &&
                      value[2] < value[0] + value[1]))
                {
                    throw new ArgumentException();
                }

                Array.Sort(value);

                this.edges = value;
            }
            get { return edges; }
            }

        /// <summary>
        /// Initializes a new instance of the MyLib.Triangle class
        /// </summary>
        /// <param name="a">first edge of Triangle</param>
        /// <param name="b">second edge of Triangle</param>
        /// <param name="c">third edge of Triangle</param>
        public Triangle (double a, double b, double c)
        {
            Edges = new double[] {a, b, c};
            Array.Sort(Edges);
            foreach (double edge in Edges)
            {
                P += edge;
            }
        }

        /// <summary>
        /// calculates the area of ​​a triangle given three edges
        /// </summary>
        /// <returns>area of a triangle</returns>
        public double CalculateArea()
        {
            double p = P / 2;

            return isOrthogonalTriangle() ? (Edges[0] * Edges[1]) / 2 : Math.Sqrt(p * (p - Edges[0]) * (p - Edges[1]) * (p - Edges[2]));
        }

        /// <summary>
        /// Indicates whether the specified triangle is orthogonal or not
        /// </summary>
        /// <returns>true if the triangle is orthogonal; otherwise, false.</returns>
        public bool isOrthogonalTriangle()
        {
            bool isOrthogonal = Edges[0] * Edges[0] + Edges[1] * Edges[1] == Edges[2] * Edges[2] ? true : false;
            return isOrthogonal;
        }
    }
}
