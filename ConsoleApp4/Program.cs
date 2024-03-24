using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address newaddress = new Address();
            newaddress.InputAddress();
            newaddress.PrintAddress();
            Console.ReadKey();
        }
    }
}
