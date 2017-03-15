using System;

namespace UsdToBgn
{
    class UsdToBgn
    {
        static void Main(string[] args)
        {
            var amountUsd = double.Parse(Console.ReadLine());
            var exchange = 1.79549;
            var amountBgn = amountUsd * exchange;
            Console.WriteLine("{0:F2} BGN", amountBgn);
        }
    }
}
