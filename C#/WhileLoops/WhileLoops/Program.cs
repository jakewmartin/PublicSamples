using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            Console.Write("Enter your first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("What is the value of " + numberA + " X " + numberB + "?");
            Console.WriteLine();

            /*while (answer != actualAnswer)
            {
                Console.WriteLine("Enter your guess: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Not correct, guess again!");
                    Console.WriteLine();
                }
            }*/

            do
            {
                //does the logic first, then checks condition at end
                Console.WriteLine("Enter your guess: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Not correct, guess again!");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Correct, well done!");
            Console.ReadLine();
        }
    }
}
