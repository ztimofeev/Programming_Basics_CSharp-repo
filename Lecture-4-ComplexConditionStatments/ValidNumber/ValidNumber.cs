using System;

namespace ValidNumber
{
    class ValidNumber
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var validRange = number >= 100 && number <= 200 || number == 0;
            if (!validRange)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
