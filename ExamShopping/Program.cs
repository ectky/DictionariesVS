using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var inventory = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                string[] list = input.Split(' ');
                if (!inventory.ContainsKey(list[1]))
                {
                    inventory[list[1]] = 0;
                }
                inventory[list[1]] += int.Parse(list[2]);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "exam time")
            {
                string[] list = input.Split(' ');
                if (inventory.ContainsKey(list[1]))
                {
                    if (inventory[list[1]] <= 0)
                    {
                        Console.WriteLine($"{list[1]} out of stock");
                    }
                    else
                    {
                        int quantity = int.Parse(list[2]);
                        if (quantity >= inventory[list[1]])
                        {
                            inventory[list[1]] = 0;
                        }
                        else
                        {
                            inventory[list[1]] -= quantity;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{list[1]} doesn't exist");
                }

                input = Console.ReadLine();
            }

            foreach (var pair in inventory)
            {
                if (pair.Value > 0)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
