using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int length = 10;

            int[] multiples = new int[length];

            for (int i = 0; i < multiples.Length; i++)
            {
                multiples[i] = num * (i+1);
            }

            foreach (var item in multiples)
            {
                Console.Write($"{item}, ");
            }



            Console.ReadLine();
        }
    }
}
