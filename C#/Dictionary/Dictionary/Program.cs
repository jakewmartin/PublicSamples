using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<int, string> names = new Dictionary<int, string>//();
            {
                //keyValue pair
                //names.Add(1, "Jake");
                //names.Add(2, "Test");
                //names.Add(3, "Test");
                { 1, "Jake" },
                { 2, "Test" },
                { 3, "Test" }
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                //Console.WriteLine(names[i]); //gives index error
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            foreach (KeyValuePair<int,string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            } */

            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                {"Math", "jake" },
                {"Science", "test" }
            };

            //Console.WriteLine(teachers["math"]); //int.TryParse Convert, this will
            //fail due to math not being in dict

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }

            teachers.Remove("Math"); //if case isn't found, simply wont remove

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }
           

            foreach (KeyValuePair<int, string> item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
