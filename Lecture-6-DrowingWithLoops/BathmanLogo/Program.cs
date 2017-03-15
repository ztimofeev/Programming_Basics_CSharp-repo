using System;

namespace BathmanLogo
{
    class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();

            

            for (int i = 0; i < n / 2; i++)
            {
                if (i == n / 2 - 1)
                {
                    var bottomOfTopPart = new string(' ', (n - 3) / 2) + symbol + ' ' + symbol + new string(' ', (n - 3) / 2);
                    var top = new string(' ', i) + MagicStr(symbol, n - i) + bottomOfTopPart + MagicStr(symbol, n - i) + new string(' ', i);
                    Console.WriteLine(top);
                }
                else
                {
                    var top = new string(' ', i) + MagicStr(symbol, n - i) + new string(' ', n) + MagicStr(symbol, n - i) + new string(' ', i);
                    Console.WriteLine(top);
                } 
            }
            for (int i = 0; i < n / 3; i++)
            {
                var middle = new string(' ', n / 2) + MagicStr(symbol, 2 * n + 1);
                Console.WriteLine(middle);
            }
            for (int i = 0; i < n / 2; i++)
            {
                var bottom = new string(' ', n + 1 + i) + MagicStr(symbol, n - 2 - 2 * i);
                Console.WriteLine(bottom);
            }
        }


        public static string MagicStr(string text, int repeatCount)
        {
            string outputString = "";
            for (int i = 0; i < repeatCount; i++)
            {
                outputString += text;
            }
            return outputString;
        }
    }
}
