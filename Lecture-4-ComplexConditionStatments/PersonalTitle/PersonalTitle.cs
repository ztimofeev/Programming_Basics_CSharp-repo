using System;

namespace PersonalTitle
{
    class PersonalTitle
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            if (gender == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            else if (gender == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
