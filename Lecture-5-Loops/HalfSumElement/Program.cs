using System;
using System.Runtime.CompilerServices;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var current = int.Parse(Console.ReadLine());
                sum += current;
                if (current > maxNumber)
                {
                    maxNumber = current;
                }
            }
            var diff = sum - maxNumber;
            if (maxNumber == diff)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", diff);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(maxNumber - diff));
            }
        }
    }
}
