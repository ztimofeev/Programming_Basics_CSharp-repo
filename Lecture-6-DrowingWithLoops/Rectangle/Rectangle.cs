using System;

namespace Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < rows; cols++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
