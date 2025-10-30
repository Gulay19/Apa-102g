using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptionss.Models.Exceptions
{
    internal class IncorrectPasswordException : Exception
    {

        public int AttemptsLeft { get; set; }
        public IncorrectPasswordException(int attemptsLeft)
            : base($"Password is incorrect. Attempts left: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }

        public IncorrectPasswordException(string message)
            : base(message)
        {
        }
    }
}
