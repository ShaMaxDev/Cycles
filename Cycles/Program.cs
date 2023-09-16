using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What do you want me to repeat?");
            string userMessage = Console.ReadLine();
            Console.WriteLine("Ok. How many times?");

            for (int repeatNumber = Convert.ToInt32(Console.ReadLine()); repeatNumber > 0; repeatNumber -- )
            {
                Console.WriteLine(userMessage); 
            }

            Console.WriteLine("That's it.");
            Console.ReadKey();
        }
    }
}
