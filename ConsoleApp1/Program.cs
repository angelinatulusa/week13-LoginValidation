using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin2";
            string pasword = "pass1234";

            strinf userName, userPassword;

            Console.WriteLine("enter your username");
            userName = Console.ReadLine();
            Console.WriteLine("enter your password");
            userPassword = Console.ReadLine();

            if(login == userName && userPassword == userPassword)
                Console.WriteLine("welcome!")

            else
                Console.WriteLine("Oops, something went wrong")

        }
    }
}
