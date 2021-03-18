using System;
using System.Collections.Generic;
using System.Collections;

namespace Exception_Account
{
    class Program
    {
        static void Main()
        {
            Account account = new Account();
            try
            {
                account.Login = "abc";
            }
            catch (LoginException ex) when (ex.Message.Length > 5)
            {
                Console.WriteLine($"Message : {ex.Message}");
                Console.WriteLine($"Message : {ex.HelpLink}");
                Console.WriteLine($"Time error : {ex.Data["Time"]}");

                foreach (DictionaryEntry item in ex.Data)
                {
                    Console.WriteLine($"{item.Key}");
                }
            }
        }
    }
}
