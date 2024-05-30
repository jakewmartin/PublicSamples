using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "hello";
            string compare = "hello";

            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("diff");
            }

            if (!message.Equals(compare))
            {
                Console.WriteLine($"Your name is {message}.");
            }


            //.Equals compares the literal values NOT the memory address like "=="
            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newcompare = new string(chars);

            if (message.Equals(newcompare))
            
                Console.WriteLine("Same");
            
            else
            
                Console.WriteLine("Diff");
            

        }

    }
}
