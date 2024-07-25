using System;

//All about ReadLine() and Writeline()
namespace MyApplication
{
    class program
    {
        
            static void Main()
            {
                Console.WriteLine("Enter your First name");
                string Firstname = Console.ReadLine();
                Console.WriteLine("Enter your Last name");
                string Lastname = Console.ReadLine();

                Console.WriteLine("Hello {0} {1}", Firstname, Lastname);

            
        }
            
    }
}

