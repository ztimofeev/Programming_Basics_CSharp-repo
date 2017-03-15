using System;
using System.Globalization;

namespace _1000daysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "dd-MM-yyyy";
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), format, provider).AddDays(1000);
            
            Console.WriteLine(birthDate.ToString("dd-MM-yyyy"));
        }
    }
}
