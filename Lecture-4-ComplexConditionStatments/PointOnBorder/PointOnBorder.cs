using System;

namespace PointOnBorder
{
	class PointOnBorder
	{
		static void Main(string[] args)
			{
			var x1 = double.Parse(Console.ReadLine());
			var y1 = double.Parse(Console.ReadLine());
			var x2 = double.Parse(Console.ReadLine());
			var y2 = double.Parse(Console.ReadLine());
			var x = double.Parse(Console.ReadLine());
			var y = double.Parse(Console.ReadLine());

			Boolean borderX = (y == y1 || y == y2) && (x >= x1 && x <= x2);
			Boolean borderY = (x == x1 || x == x2) && (y >= y1 && y <= y2);

			if (borderX || borderY)
			{
				Console.WriteLine("border");
			}
			else
			{
				Console.WriteLine("Inside / Outside");
			}
		}
	}
}
