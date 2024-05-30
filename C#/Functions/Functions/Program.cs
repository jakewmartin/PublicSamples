using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Test
    {
        public void something() //static
        {
            Console.WriteLine();
        } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Test.something(); with static

            //Test test = new Test(); without static
            //test.something();

            WelcomeMessage();

            Console.ReadLine();
        }


        //Static -- accessible everywhere, does not need to create an instance to access
        //Public means full access
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my program");
        }
    }
}
