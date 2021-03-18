using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Account
{
    class LoginException : ApplicationException
    {
        public LoginException(string message)
            : base(message)
        {

        }
    }
}
