using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_Day_3
{
    internal class BankAccount
    {
        private string client;
        private int accountNo;
        private double balance;

        public void InitializeBankAccount(string newClient, int newAccountNo)
        {
            this.client = newClient;
            this.accountNo = newAccountNo;
            this.balance = 0;
        }

        public void DepositMoney(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
            }
        }
        public bool WithdrawMoney(double amount)
        {
            if (amount < this.balance && amount>0)
            {
                this.balance -= amount;
                return true;
            }
            else { return false; }
        }
        public string GetInfo()
        {
            return $"Client - {this.client} ({this.accountNo})\nBalance - {this.balance} euro(s)";
        }
    }
}
