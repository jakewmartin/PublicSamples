using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {;
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Name is empty.");
            }
                


            Console.ReadLine();
        }
    }
}
