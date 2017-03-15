using System;

namespace NumberInRange1to100
{
    class NumberInRange1to100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Еnter a number in the range [1...100]: ");
            var input = int.Parse(Console.ReadLine());

            var invalidNumber = input <= 0 || input > 100;

            while (invalidNumber)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                input = int.Parse(Console.ReadLine());
                if (input > 0 && input <= 100)
                {
                    break;
                }
            }
            Console.WriteLine("The number is: " + input);
        }
    }
}
