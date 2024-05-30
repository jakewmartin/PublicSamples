using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
                new int[]
            {
                90, 199, 22, 50, 30
            };

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //int position = Array.IndexOf(numbers, search);      //everything
            //int position = Array.IndexOf(numbers, search, 2);   //2 to the end
            //int position = Array.IndexOf(numbers, search, 1,2); //specific range

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found.");
            }
            Console.ReadLine();
        }
    }
}
