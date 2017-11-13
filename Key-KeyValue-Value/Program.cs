using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_KeyValue_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, List<string>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                string inputKey = input[0];
                string[] inputValues = input[1].Split(';');

                if (inputKey.Contains(key))
                {
                    var list = new List<string>();
                    for (int j = 0; j < inputValues.Length; j++)
                    {
                        if (inputValues[j].Contains(value))
                        {
                            list.Add(inputValues[j]);
                        }
                    }
                    
                    result.Add(inputKey, list);
                }

            }

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (var item in pair.Value)
                {
                    Console.WriteLine($"-{item}");
                }
            }

        }
    }
}
