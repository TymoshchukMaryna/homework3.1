using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Figure
    {
        Point[] figure;
        public Figure(params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                Console.WriteLine("Кількість точок повинна бути від 3 до 5.");
            }
            this.figure = points;
        }

        public double LengthSide(Point A, Point B)
        {
            double lenght_side = 0;
            lenght_side = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return lenght_side;
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < figure.Length; i++)
            {
                perimeter += LengthSide(figure[i], figure[(i + 1) % figure.Length]);
            }
            Console.WriteLine($"Периметр багатокутника: {perimeter}");

        }
    }
}

