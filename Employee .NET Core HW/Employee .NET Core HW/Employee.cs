using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Employee_.NET_Core_HW
{
    class Employee
    {
        private string name;
        private ushort salary;
        private readonly int ID;
        private static int counter;
        public Employee(string name, ushort salary)
        {
            Name = name;
            Salary = salary;
            ID = ++counter;
        }
        public string Name
        {
            get => name;
            set
            {
                if (name == null)
                {
                    if (value.All(x => char.IsLetter(x)))
                    {
                        name = value;
                    }
                    else
                    {
                        throw new LoginLetterException("The name has bad value type, it may has numbers or different other bad symbol.");
                    }
                }
                else
                {
                    throw new NullException("Name is empty. (null)");
                }
            }
        }
        public ushort Salary
        {
            get => salary;
            set => salary = value;
        }
        
    }
}
