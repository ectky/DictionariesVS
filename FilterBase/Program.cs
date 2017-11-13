using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var ages = new Dictionary<string, int>();
            var salaries = new Dictionary<string, double>();
            var positions = new Dictionary<string, string>();

            while (input != "filter base")
            {
                string[] list = input.Split(new char[] { ' ', '-', '>' });
                if (int.TryParse(list[4], out int age))
                {
                    ages[list[0]] = age;
                }
                else if (double.TryParse(list[4], out double salary))
                {
                    salaries[list[0]] = salary;
                }
                else
                {
                    positions[list[0]] = list[4];
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            if (input == "Age")
            {
                foreach (var pair in ages)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Age: {pair.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input == "Salary")
            {
                foreach (var pair in salaries)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Salary: {pair.Value:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (var pair in positions)
                {
                    Console.WriteLine($"Name: {pair.Key}");
                    Console.WriteLine($"Position: {pair.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
