using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptionss.Models.Exceptions
{
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException()
            : base("User not found.")
        {
        }

        public UserNotFoundException(string username)
            : base(username)
        {
        }
    }
}
