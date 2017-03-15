using System;

namespace TimePlus15minutes
{
    class TimePluse15Minutes
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            int temp = minutes + 15;
            if (temp >= 60)
            {
                hours += 1;
                temp -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            } 
            if (temp < 10)
            {
                Console.WriteLine($"{hours}:0{temp}");
            } else
            {
                Console.WriteLine($"{hours}:{temp}");
            }
        }
    }
}
