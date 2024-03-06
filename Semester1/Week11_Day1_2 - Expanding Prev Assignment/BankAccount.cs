using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Day1_2
{
    internal class BankAccount
    {
        private int _balanceInCents;

        public BankAccount()
        {
            _balanceInCents = 0;
        }

        public Boolean WithdrawMoney(int amount)
        {
            if (amount > 0 && amount<_balanceInCents)
            {
                _balanceInCents -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean DepositMoney(int amount)
        {
            if (amount > 0)
            {
                _balanceInCents += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetBalance()
        {
            return _balanceInCents;
        }

        public override string ToString()
        {
            decimal _balanceInDecimals = _balanceInCents;
            _balanceInDecimals /= 100;
            return Convert.ToString(_balanceInDecimals);
        }

    }
}
