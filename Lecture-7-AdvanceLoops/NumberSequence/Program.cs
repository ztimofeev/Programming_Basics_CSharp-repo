using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= n; cols++)
                {
                    num = rows * cols;
                    Console.Write("{0:00 }", num * num);
                }
                Console.WriteLine();
            }
        }
    }
}
