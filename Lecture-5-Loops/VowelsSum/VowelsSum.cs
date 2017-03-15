using System;

namespace VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                switch (letter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
