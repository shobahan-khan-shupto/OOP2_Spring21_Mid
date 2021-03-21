using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public string GetAccName()
        {
            return this.accName;
        }

        public void SetAccName(string accName)
        {
            this.accName = accName;
        }

        public string GetAcId()
        {
            return this.acid;
        }

        public void SetAcId(string acid)
        {
            this.acid = acid;
        }

        public int GetBalance()
        {
            return this.balance;
        }

        public void SetBalance(int balance)
        {
            this.balance = balance;
        }


        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;

        }

        public void Deposit(int amount)
        {
            if (amount > 0)
                balance += amount;

            Console.WriteLine("Deposit of {0} taka complete", amount);
        }
    }
    public void Withdraw(int amount)
    {
        if (this.balance - amount >= 500)
        {
            this.balance -= amount;
            Console.WriteLine("Withdraw of {0} taka complete", amount);
        }
    }


    public void ShowAccontInfo()
    {
        Console.WriteLine("Accont Info:");
        Console.WriteLine("Account Name: {0}", this.GetAccName());
        Console.WriteLine("ID: {0}", this.GetAcId());
        Console.WriteLine("Balance: {0}", this.GetBalance());
    }
}




