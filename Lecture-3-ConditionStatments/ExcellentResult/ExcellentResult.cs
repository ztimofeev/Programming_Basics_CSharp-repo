using System;
using System.Xml;

namespace ExcellentResult
{
    class ExcellentResult
    {
        static void Main(string[] args)
        {
            var grade = Double.Parse(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
