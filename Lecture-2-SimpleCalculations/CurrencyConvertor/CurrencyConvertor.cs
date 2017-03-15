using System;

namespace CurencyConverter
    {
        class CurrencyConverter
        {
            static void Main(string[] args)
            {
                var usdToBgn = 1.79549;
                var eurToBgn = 1.95583;
                var gbpToBgn = 2.53405;
                var amount = double.Parse(Console.ReadLine());
                var fromCurrency = Console.ReadLine();
                var toCurrency = Console.ReadLine();
                var leva = 0.0;
                var result = 0.0;

                if (fromCurrency == "USD")
                {
                    leva = amount * usdToBgn;
                }
                else if (fromCurrency == "EUR")
                {
                    leva = amount * eurToBgn;
                }
                else if (fromCurrency == "GBP")
                {
                    leva = amount * gbpToBgn;
                }
                else if (fromCurrency == "BGN")
                {
                    leva = amount;
                }
                if (toCurrency == "BGN")
                {
                    result = leva;
                }
                else if (toCurrency == "USD")
                {
                    result = leva / usdToBgn;
                }
                else if (toCurrency == "EUR")
                {
                    result = leva / eurToBgn;
                }
                else if (toCurrency == "GBP")
                {
                    result = leva / gbpToBgn;
                }
                Console.WriteLine("{0:F2} {1}", result, toCurrency);
            }
        }
    }


