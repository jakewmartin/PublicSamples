using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIsNullFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            if (name != "")
            {
                Console.WriteLine("0");
            }

            if (!name.Equals(""))
                Console.WriteLine("1");

            if (!string.IsNullOrEmpty(name)) //null AND ""
                Console.WriteLine("2");

            if (!string.IsNullOrEmpty(name)) //better to nest existance checks like this
            {                                //it avoids failures in the code.
                if (name.Equals("Aba"))
                {
                    Console.WriteLine("Correct");
                }
            }

            Console.ReadLine();
        }
    }
}
