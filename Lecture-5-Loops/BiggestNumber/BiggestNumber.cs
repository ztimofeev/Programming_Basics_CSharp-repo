using System;

namespace BiggestNumber
{
    class BiggestNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
