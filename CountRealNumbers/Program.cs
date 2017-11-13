using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var numbersCount = new SortedDictionary<double, int>();

            for (int i = 0; i < numbersInput.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbersInput[i]))
                {
                    numbersCount[numbersInput[i]] = 0;
                }

                numbersCount[numbersInput[i]]++;
            }

            foreach (KeyValuePair<double, int> pair in numbersCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
