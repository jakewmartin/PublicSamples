using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunctions
{
    internal class Program
    {
        //static string name = "Jake"; //we dont like global variables
        static void Main(string[] args)
        {
            Console.Title = $"{ReturnName()} - {ReturnAge()}";
            PrintIntroduction();
            Console.ReadLine();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.Write("Enter a number: ");
                //numbers[i] = Convert.ToInt32(Console.ReadLine());
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            int[] newNumbers = CreateRandomArray();

            foreach (var item in newNumbers)
            {
                Console.Write(item);
            }

            //Console.Write("Enter a number: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());

        }

        static int[] CreateRandomArray()
        {
            /* int[] numbers = new int[3]
            {
                0,
                1,
                2
            };

            return numbers; */

            return new int[3] { 1, 2, 3 };
        }

        static int ReadNumberFromConsole() 
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "Jake";
        }

        static int ReturnAge()
        {
            return 28;
        }

        static void PrintIntroduction()
        {
            /* string name = ReturnName();
            int age = ReturnAge();
            string output = $"Hello my name is {name} and my age is {age}!";
            Console.WriteLine(output); */
            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}!");
        }
    }
}
