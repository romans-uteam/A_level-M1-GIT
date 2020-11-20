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

            string output = input;

            File.WriteAllText("OUTPUT.TXT", output);
        }
    }
}
