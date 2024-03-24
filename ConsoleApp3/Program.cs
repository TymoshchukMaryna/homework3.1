using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A:
            Console.WriteLine("Оберіть вид багатокутника: 1-трикутник, 2-чотирикутник, 3-пятикутник");
            var choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Введіть координати 3 точок та їх назви");
                       
                            Console.WriteLine("1 точка: ");
                            int a = int.Parse(Console.ReadLine());
                            int b = int.Parse(Console.ReadLine());
                            string name = Console.ReadLine();
                            Point point1 = new Point(a,b,name);
                            Console.WriteLine("2 точка: ");
                            a = int.Parse(Console.ReadLine());
                            b = int.Parse(Console.ReadLine());
                            name = Console.ReadLine();
                            Point point2 = new Point(a, b, name);
                            Console.WriteLine("3 точка: ");
                            a = int.Parse(Console.ReadLine());
                            b = int.Parse(Console.ReadLine());
                            name = Console.ReadLine();
                            Point point3 = new Point(a, b, name);

                        Figure newfigure = new Figure(point1, point2, point3);
                        Console.WriteLine($"Назва фігури {point1.Name}{point2.Name}{point3.Name}");
                        newfigure.PerimeterCalculator();
                        break;
                    }
                case 2:
                    {

                        Console.WriteLine("Введіть координати 4 точок та їх назви");

                        Console.WriteLine("1 точка: ");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        string name = Console.ReadLine();
                        Point point1 = new Point(a, b, name);
                        Console.WriteLine("2 точка: ");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        name = Console.ReadLine();
                        Point point2 = new Point(a, b, name);
                        Console.WriteLine("3 точка: ");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        name = Console.ReadLine();
                        Point point3 = new Point(a, b, name);
                        Console.WriteLine("4 точка: ");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        name = Console.ReadLine();
                        Point point4 = new Point(a, b, name);

                        Figure newfigure = new Figure(point1, point2, point3, point4);
                        Console.WriteLine($"Назва фігури {point1.Name}{point2.Name}{point3.Name}{point4.Name}");
                        newfigure.PerimeterCalculator();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введіть координати 5 точок та їх назви");

                        Console.WriteLine("1 точка: ");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        string name = Console.ReadLine();
                        Point point1 = new Point(a, b, name);
                        Console.WriteLine("2 точка: ");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        name = Console.ReadLine();
                        Point point2 = new Point(a, b, name);
                        Console.WriteLine("3 точка: ");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        name = Console.ReadLine();
                        Point point3 = new Point(a, b, name);
                        Console.WriteLine("4 точка: ");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        name = Console.ReadLine();
                        Point point4 = new Point(a, b, name);
                        Console.WriteLine("5 точка: ");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        name = Console.ReadLine();
                        Point point5 = new Point(a, b, name);

                        Figure newfigure = new Figure(point1, point2, point3, point4);
                        Console.WriteLine($"Назва фігури {point1.Name}{point2.Name}{point3.Name}{point4.Name}{point5.Name}");
                        newfigure.PerimeterCalculator();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ви ввели неправильні дані, спробуйте ще");
                       goto A;
                    }
            }
            Console.ReadKey();
        }
    }
}
