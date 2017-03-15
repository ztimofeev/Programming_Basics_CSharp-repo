using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var topBottom = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
            var middle = '*' + new string('/', 2 * n - 2) + '*';

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.WriteLine(topBottom);
                }
                else
                {
                    if (i == (n + 1) / 2)
                    {
                        Console.WriteLine(middle + new string('|', n) + middle);
                    }
                    else
                    {
                        Console.WriteLine(middle + new string(' ', n) + middle);
                    }
                }
            }
        }
    }
}
