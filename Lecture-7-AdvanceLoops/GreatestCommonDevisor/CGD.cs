using System;

namespace GreatestCommonDevisor
{
    class CGD
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            while (secondNumber > 0)
            {
                var temp = 0;
                temp = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }
            Console.WriteLine(firstNumber);
        }
    }
}
