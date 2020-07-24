using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // DisplayGreeting("Brice");

            for (int i=1; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} - even");
                }
                else
                {
                    Console.WriteLine($"{i} - odd");
                }
            }
        }

        static void DisplayGreeting(string name)
        {
            var greeting = "Hi";
            Console.WriteLine(greeting + " " + name);
        }

    }
}
