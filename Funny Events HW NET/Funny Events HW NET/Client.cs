using System;
using System.Collections.Generic;
using System.Text;

namespace Funny_Events_HW_NET
{
    class Client
    {
        private string name;
        private decimal phoneNumber;

        public Client(string name = "Noname", decimal phoneNumber = 0)
        {
            this.name = name;

            if (phoneNumber % 100000000 == 0)
            {
                this.phoneNumber = phoneNumber;
            }
            else
            {
                this.phoneNumber = 0;
            }
        }
        public override string ToString()
        {
            return ($"Name : {name}\tPhoneNumber : {phoneNumber}");
        }
    }
}
