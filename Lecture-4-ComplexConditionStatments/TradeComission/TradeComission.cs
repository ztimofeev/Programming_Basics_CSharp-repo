using System;

namespace TradeComission
{
    class TradeComission
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());

            double comission = 0;

            if (sales < 0 || (city != "sofia" && city != "varna" && city != "plovdiv"))
            {
                Console.WriteLine("error");
            }
            else
            {
                if (city == "sofia")
                {
                    if (sales <= 500)
                    {
                        comission = sales * 0.05;
                    }
                    else if (sales <= 1000)
                    {
                        comission = sales * 0.07;
                    }
                    else if (sales <= 10000)
                    {
                        comission = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        comission = sales * 0.12;
                    }
                }
                else if (city == "varna")
                {
                    if (sales <= 500)
                    {
                        comission = sales * 0.045;
                    }
                    else if (sales <= 1000)
                    {
                        comission = sales * 0.075;
                    }
                    else if (sales <= 10000)
                    {
                        comission = sales * 0.1;
                    }
                    else if (sales > 10000)
                    {
                        comission = sales * 0.13;
                    }
                }
                else if (city == "plovdiv")
                {
                    if (sales <= 500)
                    {
                        comission = sales * 0.055;
                    }
                    else if (sales <= 1000)
                    {
                        comission = sales * 0.08;
                    }
                    else if (sales <= 10000)
                    {
                        comission = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        comission = sales * 0.145;
                    }
                }
                Console.WriteLine("{0:f2}", comission);
            }
        }
    }
}
