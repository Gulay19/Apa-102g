using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptionss.Models.Exceptions
{
    public class InvalidUsernameException: Exception
    {
        //Task: Login System with Custom Exceptions
        public InvalidUsernameException()
            : base("Username is invalid.") 
        {
        }

        public InvalidUsernameException( string message)
            : base(message) 
        {
        }

    }
}
