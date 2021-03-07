using System;

namespace ATM.__.NET_
{
    // class ATM : login- password*
    // + ctor (id, money) 
    // + ShowBalance()
    // + AddMoney()
    // + Withdraw()
    // Main() : menu

    class ATM
    {
        private int id;
        private int money;
        private string log;
        private string pass;

        public ATM(int id, int money, string log, string pass)
        {
            this.id = id;
            this.money = money;
            this.pass = pass;
            this.log = log;
        }

        void showBalance()
        {
            Console.WriteLine($"Your balance : {money}");
        }
        
        void addBalance(int money)
        {
            this.money += money;
        }

        void withDraw(int money)
        {
            if (money >= this.money)
            {
                this.money -= money;
            }
            else {
                throw new Exception("Money is to low to draw them. ;D");
            }
        }

        public override string ToString()
        {
            return $"ID : {id} Money : {money}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ATM num = new ATM(5, 50, "log", "pass");

            Console.WriteLine("[+]. Show balance");
            Console.WriteLine("[-]. With draw");
            Console.WriteLine("[*]. Add balance");
            char choose = char.Parse(Console.ReadLine());

            switch (choose)
            {
                case '+': {        
                        Console.WriteLine($"{}");
                } break;

                case '-': {

                } break;

                case '*': {

                } break;
            }
        }
    }
}
