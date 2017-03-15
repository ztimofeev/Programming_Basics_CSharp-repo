using System;

namespace RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            const double ratio = 57.2957795;
            var rad = double.Parse(Console.ReadLine());
            var degrees = Math.Round(rad * ratio);
            Console.WriteLine($"{degrees} degrees");
        }
    }
}