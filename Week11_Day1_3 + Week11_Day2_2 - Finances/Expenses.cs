using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Day1_3
{
    internal class Expenses
    {
        private string _name;
        private decimal _value;

        public Expenses(string name, decimal value)
        {
            _name = name;
            _value = value;
        }

        public decimal GetValue()
        {
            return _value;
        }

        public string GetInfo()
        {
            return _name + " - " + _value.ToString("0.00") + "e ";
        }
    }
}
