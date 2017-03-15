using System;

namespace OddEvenPosition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenMin = double.MaxValue;
            var oddMin = double.MaxValue;
            var evenMax = double.MinValue;
            var oddMax = double.MinValue;
            double evenSum = 0.0;
            double oddSum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var current = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum = evenSum + current;
                    if (current > evenMax)
                    {
                        evenMax = current;
                    }
                    if (current < evenMin)
                    {
                        evenMin = current;
                    }
                }
                else
                {
                    oddSum += current;
                    if (current > oddMax)
                    {
                        oddMax = current;
                    }
                    if (current < oddMin)
                    {
                        oddMin = current;
                    }
                }
            }
            Console.WriteLine("OddSum={0},", oddSum);
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0},", oddMin);
                Console.WriteLine("OddMax={0},", oddMax);
            }
            Console.WriteLine("EvenSum={0},", evenSum);
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0},", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }
        }
    }
}
