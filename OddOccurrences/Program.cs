using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, int>();

            string[] wordsInput = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < wordsInput.Length; i++)
            {
                if (!words.ContainsKey(wordsInput[i]))
                {
                    words[wordsInput[i]] = 0;
                }

                words[wordsInput[i]]++;
            }

            var result = new List<string>();

            foreach (KeyValuePair<string, int> pair in words)
            {
                if (pair.Value % 2 == 1)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
