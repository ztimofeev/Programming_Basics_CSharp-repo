using System;

namespace EvenOddSum
{
    class EvenOddSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;
            for (int i = 0; i < n; i++)
            {
                var current = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += current;
                }
                else
                {
                    oddSum += current;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(evenSum - oddSum));
            }
        }
    }
}
