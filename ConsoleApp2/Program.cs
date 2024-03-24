using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.InitializeDocument();
            book.Show();
            Console.ReadKey();
        }
    }
}
