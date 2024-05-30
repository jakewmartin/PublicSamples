using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatimStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //\t \n \" \\
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course";
            Console.WriteLine(path);

            path = @"C:\Users\coffeeNCode\Desktop\C# Course" + "\n";
            Console.WriteLine(path);

            //need "" when using @ for "
            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
