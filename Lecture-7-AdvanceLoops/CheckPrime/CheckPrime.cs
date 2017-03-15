using System;

namespace CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine("Not prime");
                return;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not prime");
                    return;
                }
            }
            Console.WriteLine("Prime");
        }
    }
}
