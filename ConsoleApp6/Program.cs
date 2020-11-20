using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("INPUT.TXT");

            string[] numbers = input.Split(' ');

            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            int sum = a + b;

            string output = sum.ToString();

            File.WriteAllText("OUTPUT.TXT", output);
        }
    }
}
