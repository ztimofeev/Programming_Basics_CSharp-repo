using System;

namespace Frame
{
    class Frame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var topBottomBorder = "+" + MagicStr(" -", n - 2) + " +";
            var middle = '|' + MagicStr(" -", n - 2) + " |";

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine(topBottomBorder);
                }
                else
                {
                    Console.WriteLine(middle);
                }
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
