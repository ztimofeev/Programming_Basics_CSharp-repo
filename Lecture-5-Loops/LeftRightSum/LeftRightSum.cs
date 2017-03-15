using System;

namespace LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                var current = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    leftSum += current;
                }
                else
                {
                    rightSum += current;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                var result = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", result);
            }
        }
    }
}
