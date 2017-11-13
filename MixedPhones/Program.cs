using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dictRef = new SortedDictionary<string, long>();

            while (input != "Over")
            {
                string[] list = input.Split(':');
                string name = list[0].Substring(0, list[0].Length - 1);

                if (long.TryParse(list[1].Substring(1, list[1].Length - 1), out long number))
                {
                    dictRef[name] = number;
                }
                else
                {
                    string secondName = list[1].Substring(1, list[1].Length - 1);
                    dictRef[secondName] = int.Parse(name);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dictRef)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
