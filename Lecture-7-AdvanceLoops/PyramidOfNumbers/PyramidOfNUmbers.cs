using System;

namespace PyramidOfNumbers
{
    class PyramidOfNUmbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(count + " ");
                    if (count < n)
                    {
                        count++;
                    }
                    else
                    {
                        return;
                    }  
                }
                Console.WriteLine();
            }
        }
    }
}
