using System;

namespace PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var movieType = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            double price = 0;

            if (movieType == "premiere")
            {
                price = 12.00;
            }
            else if (movieType == "normal")
            {
                price = 7.50;
            }
            else if (movieType == "discount")
            {
                price = 5.00;
            }
            int fullHall = rows * cols;
            double profit = fullHall * price;
            Console.WriteLine("{0:f2}", profit);
        }
    }
}
