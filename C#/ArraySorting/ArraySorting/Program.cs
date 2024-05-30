using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 2 , 3, 4, 5, 6, 7
            };

            string test = "";
            test = test.Replace(" ", "");

            Array.Sort(numbers); //void return, no need to have a * = *.Sort

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
