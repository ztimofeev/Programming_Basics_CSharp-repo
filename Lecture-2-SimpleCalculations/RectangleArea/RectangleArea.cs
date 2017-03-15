using System;

namespace Task
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);
            var area = width * height;
            var perimeter = 2 * (width + height);
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}
