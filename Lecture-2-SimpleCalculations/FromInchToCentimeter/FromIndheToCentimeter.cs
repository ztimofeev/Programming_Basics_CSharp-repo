using System;

namespace FromInchToCentimeter
{
    class FromIndheToCentimeter
    {
        static void Main(string[] args)
        {
            var multiplayer = 2.54;
            Console.Write("inches: ");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * multiplayer;
            Console.WriteLine($"centimeters = {centimeters}");
        }
    }
}
