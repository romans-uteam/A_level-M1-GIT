using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);

            Console.ReadKey();
        }
    }
}
