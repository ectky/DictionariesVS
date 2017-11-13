using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var users = new Dictionary<string, string>();
            int count = 0;

            while (input != "login")
            {
                string[] list = input.Split(new char[] { ' ', '-', '>' });
                users[list[0]] = list[4];
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end")
            {
                string[] list = input.Split(new char[] { ' ', '-', '>' });
                if (!users.ContainsKey(list[0]))
                {
                    Console.WriteLine($"{list[0]}: login failed");
                    count++;
                }
                else
                {
                    if (users[list[0]] == list[4])
                    {
                        Console.WriteLine($"{list[0]}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{list[0]}: login failed");
                        count++;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
