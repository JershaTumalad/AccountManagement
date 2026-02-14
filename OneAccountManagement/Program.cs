using System;

namespace OneAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserName = "NameUserr";
            string Password = "PassUser123";


            Console.WriteLine("ACCOUNT MANAGEMENT SYSTEM");
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();


            if (UserName == name && Password == pass)
            {
                Console.WriteLine("Login Successful.");

            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
