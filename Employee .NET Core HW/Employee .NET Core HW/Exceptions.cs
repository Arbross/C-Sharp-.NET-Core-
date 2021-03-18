using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_.NET_Core_HW
{
    class LoginLetterException : ApplicationException
    {
        public LoginLetterException(string message)
            : base(message)
        {

        }
    }
    class NullException : ApplicationException
    {
        public NullException(string message)
            : base(message)
        {

        }
    }
}
