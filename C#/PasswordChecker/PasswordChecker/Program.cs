using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool matching = false;

            while (!matching)
            {
                Console.WriteLine("Enter a password: ");
                string tempPass1 = Console.ReadLine();

                Console.WriteLine("Enter password again: ");
                string tempPass2 = Console.ReadLine();

                if (String.IsNullOrEmpty(tempPass2) || String.IsNullOrEmpty(tempPass1))
                    Console.WriteLine("Please enter a password.\n");
                else
                if (tempPass1.Equals(tempPass2))
                    matching = true;
                else
                    Console.WriteLine("Passwords do not match. Try again.\n");
            }
            Console.ReadLine();
        }
    }
}
