using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var typeOfYear = Console.ReadLine().ToLower();
            var hollydays = int.Parse(Console.ReadLine());
            var home = int.Parse(Console.ReadLine());
            double weekends = (48 - home) * 3.0 / 4;
            double freeDays = hollydays * 2.0 / 3;
            double playTimes = weekends + freeDays + home;

            if (typeOfYear == "leap")
            {
                playTimes = playTimes * 1.15;
            }
            Console.WriteLine(Math.Floor(playTimes));
        }
    }
}
