using System;

namespace MagicString
{
    class MagicString
    {
        static void Main(string[] args)
        {
            var desireString = MagicStr("*** ", 6);
            Console.WriteLine(desireString);
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
