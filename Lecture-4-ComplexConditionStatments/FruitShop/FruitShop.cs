using System;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            double price = -1;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if (product == "banana")
                {
                    price = 2.50;
                }
                else if (product == "apple")
                {
                    price = 1.20;
                }
                else if (product == "orange")
                {
                    price = 0.85;
                }
                else if (product == "grapefruit")
                {
                    price = 1.45;
                }
                else if (product == "kiwi")
                {
                    price = 2.70;
                }
                else if (product == "pineapple")
                {
                    price = 5.50;
                }
                else if (product == "grapes")
                {
                    price = 3.85;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (product == "banana")
                {
                    price = 2.70;
                }
                else if (product == "apple")
                {
                    price = 1.25;
                }
                else if (product == "orange")
                {
                    price = 0.90;
                }
                else if (product == "grapefruit")
                {
                    price = 1.60;
                }
                else if (product == "kiwi")
                {
                    price = 3.00;
                }
                else if (product == "pineapple")
                {
                    price = 5.60;
                }
                else if (product == "grapes")
                {
                    price = 4.20;
                }
            }
            if (price != -1)
            {
                double total = quantity * price;
                Console.WriteLine("{0:f2}", total);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
