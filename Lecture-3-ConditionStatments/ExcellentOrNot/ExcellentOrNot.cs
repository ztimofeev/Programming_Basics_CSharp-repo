using System;

namespace ExcellentOrNot
{
    class ExcellentOrNot
    {
        static void Main(string[] args)
        {
            var grade = Double.Parse(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            } else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
