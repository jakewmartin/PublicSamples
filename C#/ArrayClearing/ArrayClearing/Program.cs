using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            };

            //Array.Clear(numbers, 5, numbers.Length);

            for (int i = 5; i < numbers.Length; i++)
            {
                numbers[i] = default;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        
    }
}
