using System;

namespace p06_SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write(new string('*', n));
                }
                else
                {
                    Console.Write("*" + new string(' ', n - 2) + "*");
                }
                Console.WriteLine();
            }
        }
    }
}
