using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weebang, conflict!");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Hello World");
            Console.WriteLine("How are you today?");

            Console.ReadLine();
        }
    }
}
