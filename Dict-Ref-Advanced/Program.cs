using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                string[] a = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = a[0];
                try
                {
                    List<int> second = a[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToList();
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, second);
                    }
                    else
                    {
                        dict[name].AddRange(second);
                    }
                }
                catch (Exception)
                {
                    string second = a[1];
                    if (dict.ContainsKey(second))
                    {
                        if (!dict.ContainsKey(name))
                        {
                            dict.Add(name, dict[second]);
                        }
                        else
                        {
                            dict[name].Clear();
                            dict[name].AddRange(dict[second]);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} === {string.Join(", ", pair.Value)}");
            }
        }
    }
}
