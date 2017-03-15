using System;

namespace Secuence2k_1
{
    class Secuence2kPlus1
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i = 2 * i + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
