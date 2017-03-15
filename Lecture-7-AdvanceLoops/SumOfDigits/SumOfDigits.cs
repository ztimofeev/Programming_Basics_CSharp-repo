using System;

namespace SumOfDigits
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result += int.Parse(num[i].ToString());
            }
            Console.WriteLine(result);
        }
    }
}
