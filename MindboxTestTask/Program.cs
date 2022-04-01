using System;
using System.Collections.Generic;
using MyLib;

namespace MindboxTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure triangle_0 = new Triangle(4, 5, 3);
            Figure circle_0 = new Circle(2);
            Circle circle_1 = new Circle(1);
            Triangle triangle_1 = new Triangle(2, 2, 3);

            List<Figure> figures = new List<Figure> { triangle_0, circle_0, circle_1, triangle_1 };
            foreach (var figure in figures)
            {
                Console.WriteLine(Calculator.CalculateArea(figure));
            }

            Triangle triangle_2 = (Triangle)triangle_0;
            Console.WriteLine(triangle_2.isOrthogonalTriangle());
            Console.WriteLine(triangle_1.isOrthogonalTriangle());
        }
    }
}
