using System;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var inputMesure = Console.ReadLine();
            var outputMesure = Console.ReadLine();
            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;
            double toMeter = 0;
            double converted = 0;
            if (inputMesure.Equals("m"))
            {
                toMeter = distance;
            }
            else if (inputMesure == "mm")
            {
                toMeter = distance / mm;
            }
            else if (inputMesure == "cm")
            {
                toMeter = distance / cm;
            }
            else if (inputMesure == "mi")
            {
                toMeter = distance / mi;
            }
            else if (inputMesure == "in")
            {
                toMeter = distance / inch;
            }
            else if (inputMesure == "km")
            {
                toMeter = distance / km;
            }
            else if (inputMesure == "ft")
            {
                toMeter = distance / ft;
            }
            else if (inputMesure == "yd")
            {
                toMeter = distance / yd;
            }

            if (outputMesure == "m")
            {
                converted = toMeter;
            }
            else if (outputMesure == "mm")
            {
                converted = toMeter * mm;
            }
            else if (outputMesure == "cm")
            {
                converted = toMeter * cm;
            }
            else if (outputMesure == "mi")
            {
                converted = toMeter * mi;
            }
            else if (outputMesure == "in")
            {
                converted = toMeter * inch;
            }
            else if (outputMesure == "km")
            {
                converted = toMeter * km;
            }
            else if (outputMesure == "ft")
            {
                converted = toMeter * ft;
            }
            else if (outputMesure == "yd")
            {
                converted = toMeter * yd;
            }
            Console.WriteLine($"{converted} {outputMesure}");
        }
    }
}
