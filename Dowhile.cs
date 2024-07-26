using System;

namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            string password;
            do
            {
                Console.WriteLine("Enter the Password. Please ensure it must be at least 8 characters long.");
                password = Console.ReadLine();
            } while (password.Length < 8);

            Console.WriteLine("Password accepted.");
        }
    }
}
