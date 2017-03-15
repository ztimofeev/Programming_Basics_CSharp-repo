using System;

namespace MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var mathOperator = Console.ReadLine();
            var result = 0;
            String typeResult = "odd";
            
            switch (mathOperator)
            {
                case "+":
                    result = num1 + num2;
                    if (result % 2 == 0)
                    {
                        typeResult = "even";
                    }
                    Console.WriteLine($"{num1} {mathOperator} {num2} = {result} - {typeResult}");
                    break;

                case "-":
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        typeResult = "even";
                    }
                    Console.WriteLine($"{num1} {mathOperator} {num2} = {result} - {typeResult}");
                    break;

                case "*":
                    result = num1 * num2;
                    if (result % 2 == 0)
                    {
                        typeResult = "even";
                    }
                    Console.WriteLine($"{num1} {mathOperator} {num2} = {result} - {typeResult}");
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        var resultDevision = (double) num1 / num2;
                        if (resultDevision % 1 == 0)
                        {
                            resultDevision = (int) resultDevision;
                            Console.WriteLine($"{num1} {mathOperator} {num2} = {resultDevision}");
                        }
                        else
                        {
                            Console.Write($"{num1} {mathOperator} {num2} = ");
                            Console.WriteLine("{0:F2}", resultDevision);
                        }
                    }
                    break;

                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} {mathOperator} {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("unknown operator");
                    break;
            }
        }
    }
}
