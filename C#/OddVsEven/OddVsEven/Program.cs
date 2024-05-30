using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddVsEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            Console.WriteLine("Enter a top boundary: ");
            int top = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= top; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            foreach (var num in even)
            {
                Console.WriteLine(num);
            }

            foreach (var num in odd)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
