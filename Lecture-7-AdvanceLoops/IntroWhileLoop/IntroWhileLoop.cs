using System;

namespace IntroWhileLoop
{
    class IntroWhileLoop
    {
        static void Main(string[] args)
        {
            var water = 100;
            var bucket = int.Parse(Console.ReadLine());
            //while (water > 0)
            //{
            //    water -= bucket;
            //    Console.WriteLine(water);
            //}

            do
            {
                water -= bucket;
                Console.WriteLine(water);
            } while (water > 0);
        }
    }
}
