using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptionss.Models.Exceptions
{
    internal class AccountLockedException: Exception
    {
        public AccountLockedException(string message)
            : base(message)
        {
        }

    }
}
