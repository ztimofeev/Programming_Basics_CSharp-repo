using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            int greater = num1;
            if (num2 > greater)
            {
                greater = num2;
            }
            Console.WriteLine("Greater number " + greater);
        }
    }
}
