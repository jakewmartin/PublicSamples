using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;

            int[] numbers = new int[4]; //0-3

            /*Console.Write("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} {num2} {num3}");
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            for (int i = 0; i < numbers.Length; i++) //can be parameterized for length
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in numbers)  //will always go through EVERY index
            {
                Console.Write($"{i} ");
            } 
            */


            const int angleCount = 3; //for triangles
            int[] angles = new int[angleCount];
            int sum = 0;

            for (int i = 0; i < angles.Length; i++)
            {
                Console.WriteLine($"Enter angle {i + 1}");
                angles[i] = Convert.ToInt32(Console.ReadLine());
                sum += angles[i];
            }

            Console.Write(sum == 180 ? "Valid" : "Invalid");
           


            Console.ReadLine();
        }
    }
}
