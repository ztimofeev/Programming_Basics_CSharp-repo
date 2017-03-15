using System;

namespace CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var circleArea = Math.PI * r * r;
            var circlePerimeter = 2 * Math.PI * r;
            Console.WriteLine($"Area = {circleArea}");
            Console.WriteLine($"Perimeter = {circlePerimeter}");
        }
    }
}
