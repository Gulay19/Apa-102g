using System;
using _14_StatiClassExtensionMethodsExceptionss.Models.Exceptions;

namespace _14_StatiClassExtensionMethodsExceptionss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customs.LoginSystem loginSystem = new Customs.LoginSystem();
            while (true)
            {
                try
                {
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    bool success = loginSystem.Login(username, password);
                    if (success)
                    {
                        break;
                    }
                }
                catch (InvalidUsernameException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                catch (InvalidPasswordException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                catch (UserNotFoundException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    Console.WriteLine("Available users: admin, student, teacher");
                }
                catch (IncorrectPasswordException ex)
                {
                    Console.WriteLine("WARNING: " + ex.Message);
                }
                catch (AccountLockedException ex)
                {
                    Console.WriteLine("CRITICAL: " + ex.Message);
                    Console.WriteLine("Please contact the administrator.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
                }
            }

        }
    }
}
