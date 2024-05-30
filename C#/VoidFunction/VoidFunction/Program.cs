using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = int.TryParse("123", out int result);
            //this function returns a bool, some don't

            CreateAndPrintArray();
            //numbers is not accessible because of "void"
            //in CreateAndPrintArray(). it is deleted from
            //memory

            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[3]
            {
                1,2,3
            };

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item} ");
            }
        }

    }
}
