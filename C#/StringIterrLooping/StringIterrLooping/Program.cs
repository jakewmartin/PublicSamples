using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringIterrLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";

            /* Console.WriteLine(message[0]); //C
            Console.WriteLine(message[1]); //#
            Console.WriteLine(message[2]); //
            Console.WriteLine(message[3]); //i */

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(50); // 1000ms = 1sec
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals( 'C'))
                {
                    contains = true;
                }
            }

            Console.WriteLine(contains);

            Console.ReadLine();
        }
    }
}
