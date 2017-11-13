using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var charCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!charCount.ContainsKey(text[i]))
                {
                    charCount[text[i]] = 0;
                }

                charCount[text[i]]++;
            }

            foreach (KeyValuePair<char, int> pair in charCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
