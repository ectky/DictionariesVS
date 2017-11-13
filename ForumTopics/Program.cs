using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var forum = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "filter")
            {
                string[] arr = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = arr[0];
                List<string> tags = arr[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!forum.ContainsKey(topic))
                {
                    forum.Add(topic, tags);
                }
                else
                {
                    for (int i = 0; i < tags.Count; i++)
                    {
                        if (!forum[topic].Contains(tags[i]))
                        {
                            forum[topic].Add(tags[i]);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            List<string> tagis = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int count = 0;
            foreach (var pair in forum)
            {
                count = 0;
                for (int i = 0; i < tagis.Count; i++)
                {
                    if (pair.Value.Contains(tagis[i]))
                    {
                        count++;
                    }
                }

                if (count == tagis.Count)
                {
                    Console.WriteLine($"{pair.Key} | #{string.Join(", #", pair.Value)}");
                }
            }
        }
    }
}
