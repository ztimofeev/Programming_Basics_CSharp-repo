using System;

namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            if (product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" ||
                product == "grapes" || product == "banana")
            {
                Console.WriteLine("Fruit");
            }
            else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("Vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}