using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] list = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string colour = list[0];
                string[] clothes = list[1].Split(',');

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[colour].ContainsKey(clothes[j]))
                    {
                        wardrobe[colour][clothes[j]] = 0;
                    }
                    wardrobe[colour][clothes[j]]++;
                }

            }

            string[] item = Console.ReadLine().Split(' ');
            string itemColour = item[0];
            string itemType = item[1];

            foreach (var pair in wardrobe)
            {
                Console.WriteLine($"{pair.Key} clothes:");
                foreach (var secPair in pair.Value)
                {
                    Console.Write($"* {secPair.Key} - {secPair.Value}");
                    if (pair.Key == itemColour && secPair.Key == itemType)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
