using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var company = new Dictionary<string, Dictionary<string, int>>();

            while (input != "ready")
            {
                string[] a = input.Split(':');
                string town = a[0];
                string[] array = a[1].Split(',');

                if (!company.ContainsKey(town))
                {
                    company.Add(town, new Dictionary<string, int>());
                }

                for (int i = 0; i < array.Length; i++)
                {
                    string type = array[i].Split('-')[0];
                    int capacity = int.Parse(array[i].Split('-')[1]);
                    company[town][type] = capacity;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "travel time!")
            {
                string city = input.Split(' ')[0];
                int peopleCount = int.Parse(input.Split(' ')[1]);
                int sum = 0;

                foreach (var pair in company[city])
                {
                    sum += pair.Value;
                }

                if (peopleCount <= sum)
                {
                    Console.WriteLine($"{city} -> all {peopleCount} accommodated");
                }
                else
                {
                    Console.WriteLine($"{city} -> all except {peopleCount - sum} accommodated");
                }

                input = Console.ReadLine();
            }
        }
    }
}
