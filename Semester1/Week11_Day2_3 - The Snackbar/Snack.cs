using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Day2_3
{
    internal class Snack
    {
        private string _name;
        private decimal _price;
        private int _stock;
        private string _description;

        public Snack(string name, decimal price, int stock, string description)
        {
            _name = name;
            _price = price;
            _stock = stock;
            _description = description;
        }

        public Snack(string name, decimal price, int stock)
        {
            _name = name;
            _price = price;
            _stock = stock;
            _description = "";
        }

        public bool DecreaseStock(int amount)
        {
            if (amount <= _stock)
            {
                _stock -= amount;
                return true;
            }
            else { return false; }
        }

        public void IncreaseStock(int amount)
        {
            _stock += amount;
        }

        public string GetName()
        {
            return _name;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public int GetStock()
        {
            return _stock;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetListBoxFormat()
        {
            return $"{_name} - {_stock} units left - {_price} per unit";
        }

        public void EditSnack(decimal price, int stock, string description)
        {
            _price = price;
            _stock = stock;
            _description = "";
        }

        public void EditSnack(decimal price, int stock)
        {
            _price = price;
            _stock = stock;
        }
    }
}
