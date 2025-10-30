using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_StatiClassExtensionMethodsExceptionss.Models.Exceptions;

namespace _14_StatiClassExtensionMethodsExceptionss.Customs
{
    internal class LoginSystem
    {
       private User[] users;
       private const int MaxAttempts = 3;
        public LoginSystem()
        {
            users = new User[3];
            users[0] = new User("admin", "admin123");
            users[1] = new User("student", "student123");
            users[2] = new User("teacher", "teacher123");
        }
        public void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
            {
                throw new InvalidUsernameException("Username is invalid. It must be at least 3 characters long.");
            }
            return;
        }
        public void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                throw new InvalidPasswordException("Password is invalid. It must be at least 6 characters long.");
            }
            return;
        }
        private User FindUser(string username)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].UserName.ToLower() == username.ToLower())
                {
                    return users[i];
                }
            }
            return null;
        }
        public bool Login(string username, string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);
            User user = FindUser(username);
            if (user == null)
            {
                throw new UserNotFoundException(username);
            }
            if (user.IsLocked)
            {
                throw new AccountLockedException("Account is locked due to multiple failed login attempts.");
            }
            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine($"Login successful! Welcome, {username}!");
                return true;
            }
            else
            {
                user.FailedAttempts++;
                int attemptsLeft = MaxAttempts - user.FailedAttempts;
                if (attemptsLeft > 0)
                {
                    throw new IncorrectPasswordException(attemptsLeft);
                }
                else
                {
                    user.IsLocked = true;
                    throw new AccountLockedException("Account is locked to multiple failed login attempts.");
                }
            }
        }




    }
}
