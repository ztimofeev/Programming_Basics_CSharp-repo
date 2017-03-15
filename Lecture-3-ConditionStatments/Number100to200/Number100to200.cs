using System;

namespace Number100to200
{
    class Number100to200
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string label = "Between 100 and 200";
            if (number < 100)
            {
                label = "Less than 100";
            } else if (number > 200)
            {
                label = "Greater than 200";
            }
            Console.WriteLine(label);
        }
    }
}
