using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Programming
{
    internal class Program
    {
        static void Simple_Login(string[] args)
        {
            Console.WriteLine("Enter a username: ");
            string _username = Console.ReadLine();
            if (_username == "Anson")
            {
                Console.WriteLine("Enter password:");
                string _password = Console.ReadLine();
                if (_password == "123ABC")
                {
                    Console.WriteLine("Approved, welcome Anson");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Password incorrect, try again!");
                    Simple_Login(args);
                }
            }
            else
            {
                if (_username == "Bob")
                {
                    Console.WriteLine("Enter password:");
                    string _password = Console.ReadLine();
                    if (_password == "ABC123")
                    {
                        Console.WriteLine("Approved, welcome Bob");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Password incorrect, try again!");
                        Simple_Login(args);
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Simple_Login(args);
        }
    }
}
