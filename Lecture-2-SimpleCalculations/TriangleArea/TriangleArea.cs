using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.WriteLine($"Area: {area}");
        }
    }
}
