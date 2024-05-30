using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }*/

            Console.WriteLine("How many times do you want to say hi?: ");
            int loopCount = Convert.ToInt32(Console.ReadLine());

            if (loopCount <= 0)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
                for (int i = 0; i < loopCount; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
