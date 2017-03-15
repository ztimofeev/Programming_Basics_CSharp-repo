using System;

namespace PasswordGuess
{
    class PassworsGuess
    {
        static void Main(string[] args)
        {
            var inputPassword = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
            if (inputPassword == password)
            {
                Console.WriteLine("Welcome");
            } else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
