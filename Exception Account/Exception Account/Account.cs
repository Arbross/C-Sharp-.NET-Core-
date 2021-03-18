using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Account
{
    class Account
    {
        string login;
        string password;
        void CheckLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new LoginException("Login cannot be null or whitespace.");
            }
            if (login.Length < 5)
            {
                var ex = new LoginException("Too short login!");
                ex.HelpLink = "http://google.com";
                ex.Data.Add("Length ", login.Length);
                ex.Data.Add("Bad login ", login);
                // ex.Data.Add("Time ", DateTime.Now);
                ex.Data["Time"] = DateTime.Now;
                throw ex;
            }
        }
        public string Login
        {
            get => login;
            set
            {
                CheckLogin(value);
                login = value;
            }
        }
    }
}
