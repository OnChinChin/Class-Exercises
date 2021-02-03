using System;

namespace AIE_13_PasswordPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            string matchPassword = "";

            do
            {
                Console.WriteLine("Enter a password: ");
                password = Console.ReadLine();

                Console.WriteLine("Confirm a password: ");
                matchPassword = Console.ReadLine();

            } while (password != matchPassword);

            Console.WriteLine("Your password was confirmed");
            Console.WriteLine("exiting");
        }
    }
}
