using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin2";
            string password = "pass1234";

            string userName, userPassword;
            int tries = 0;

            while (tries != 3)
            {
                Console.WriteLine("enter your username");
                userName = Console.ReadLine();
                Console.WriteLine("enter your password");
                userPassword = Console.ReadLine();

                if (login != userName || Password != userPassword)
                {
                    Console.WriteLine("Oops, something went wrong");
                    tries++; //tries=tries+1
                    Console.WriteLine($"{3 - tries} attempts left");
                }
                else
                {
                    Console.WriteLine("welcome!");
                    break;
                }
            }
        } 
}
