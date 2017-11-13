using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var shells = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (input != "Aggregate")
            {
                string region = input.Split(' ')[0];
                int size = int.Parse(input.Split(' ')[1]);

                if (!shells.ContainsKey(region))
                {
                    shells.Add(region, new List<int>());
                }

                if (!shells[region].Contains(size))
                {
                    shells[region].Add(size);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in shells)
            {
                Console.WriteLine("{0} -> {1} ({2})", pair.Key, string.Join(", ", pair.Value),
                    pair.Value.Sum() - (pair.Value.Sum() / pair.Value.Count));
            }
        }
    }
}
