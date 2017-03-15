using System;

namespace Hollyday
{
    class Hollyday
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            double money = 0;
            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    money = budget * 0.3;
                    Console.WriteLine("Camp - {0:F2}", money);
                }
                else if (season == "winter")
                {
                    money = budget * 0.7;
                    Console.WriteLine("Hotel - {0:F2}", money);
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    money = budget * 0.4;
                    Console.WriteLine("Camp - {0:F2}", money);
                }
                else if (season == "winter")
                {
                    money = budget * 0.8;
                    Console.WriteLine("Hotel - {0:F2}", money);
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europa");
                    money = budget * 0.9;
                    Console.WriteLine("Hotel - {0:F2}", money);
            }
        }
    }
}
