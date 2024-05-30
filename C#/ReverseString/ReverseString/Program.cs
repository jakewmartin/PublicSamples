using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message to be reversed: ");
            string inString = Console.ReadLine();
            string outString = "";

            for (int i = inString.Length-1; i >= 0; i--)
            {
                outString += inString[i];
            }

            Console.WriteLine(inString);
            Console.Write(outString);
            Console.ReadLine();
        }
    }
}
