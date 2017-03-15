using System;

namespace EvenPowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i += 2)
            {
                var num = Math.Pow(2, i);
                Console.WriteLine(num);
            }
        }
    }
}
