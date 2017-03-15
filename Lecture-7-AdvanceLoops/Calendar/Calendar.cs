using System;

namespace Calendar
{
    class Calendar
    {
        enum Week
        {
            Mo = 1,
            Tu = 2,
            We = 3,
            Th = 4,
            Fr = 5,
            Sa = 6,
            Su = 7
        }
        private static void Main()
        {
            Console.WriteLine(" ");
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("{0} ", (Week)i);
            }
            Console.WriteLine();

            var daysOldMonth = 6;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if ((j + i * 7) > 31 + daysOldMonth)
                    {
                        break;
                    }
                    else
                    {
                        if (j <= daysOldMonth && i == 0)
                        {
                            Console.Write("   ");
                        }
                        else
                        {
                            Console.Write("{0:00} ", (j + i * 7) - daysOldMonth);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
