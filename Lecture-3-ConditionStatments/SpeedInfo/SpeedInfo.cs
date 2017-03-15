using System;

namespace SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            string speedInfo = "extremely fast";

            if (speed <= 10)
            {
                speedInfo = "slow";
            } else if (speed <= 50)
            {
                speedInfo = "average";
            } else if (speed <= 150)
            {
                speedInfo = "fast";
            } else if (speed <= 1000)
            {
                speedInfo = "ultra fast";
            }
            Console.WriteLine(speedInfo);
        }
    }
}
