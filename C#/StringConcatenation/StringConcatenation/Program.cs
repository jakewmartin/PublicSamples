using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "jake";
            int age = 28;

            Console.WriteLine($"Your name is {name} and your age is {age}");

            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(test);

            string[] names = new string[] { "Aba", "test", "test", "jake" };

            Console.WriteLine(string.Concat(names));

            Console.ReadLine();
        }
    }
}
