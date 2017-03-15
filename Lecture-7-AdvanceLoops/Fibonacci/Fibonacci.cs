using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine(2);
            }
            else
            {
                var a = 1;
                var b = 2;
                var fibo = a + b;
                for (int i = 3; i < n; i++)
                {
                    a = b;
                    b = fibo;
                    fibo = a + b;
                }
                Console.WriteLine(fibo);
            }
        }
    }
}
