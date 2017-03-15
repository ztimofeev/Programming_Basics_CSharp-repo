﻿using System;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (city == "sofia")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.50;
                        break;
                    case "water":
                        price = 0.80;
                        break;
                    case "beer":
                        price = 1.20;
                        break;
                    case "sweets":
                        price = 1.45;
                        break;
                    case "peanuts":
                        price = 1.60;
                        break;
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                    price = 0.40;
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                }
                else if (product == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (city == "varna")
            {
                if (product == "coffee")
                    price = 0.45;
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.10;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                }
            }
            double total = quantity * price;
            Console.WriteLine(total);
        }
    }
}