using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Exercise1
    {
        static void Main(string[] args)
        {
          
             Console.Write("Enter your name: ");
             string name = Console.ReadLine();
             //Console.WriteLine(name);

             Console.Write("Enter your age: ");
             int age = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine();
             Console.Write("Your name is " + name + " and your age is " + age);




             if (age < 0 || age > 150)
             {
                 Console.WriteLine("Invalid Age");
             }
             else
             {
                 if (age >= 18 && age <= 25)
                 {
                     Console.WriteLine("You are between 18 and 25");
                 }
                 else if (age > 25)
                 {
                     Console.WriteLine("You are 25 or older");
                 }
             }

            Console.ReadLine();
        }
    }
}
