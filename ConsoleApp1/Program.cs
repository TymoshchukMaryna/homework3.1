using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ширину прямокутника");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть довжину прямокутника");
            var b = double.Parse(Console.ReadLine());

            Rectangle newRectangle = new Rectangle(a, b);

            Console.WriteLine($"Периметр прямокутника {newRectangle.Perimeter}");
            Console.WriteLine($"Площа прямокутника {newRectangle.Area}");
            Console.ReadKey();
        }
    }
}
