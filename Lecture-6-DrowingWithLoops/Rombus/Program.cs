using System;

namespace Rombus
{
    class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                Console.Write(MagicStr(" ", n - rows));
                Console.WriteLine(MagicStr("* ", rows));
            }
            for (int rows = n - 1; rows > 0; rows--)
            {
                Console.Write(MagicStr(" ", n - rows));
                Console.WriteLine(MagicStr("* ", rows));
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
