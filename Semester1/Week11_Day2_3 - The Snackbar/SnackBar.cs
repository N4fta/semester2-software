using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Day2_3
{
    internal class SnackBar
    {
        private List<Snack> _snacksMenu = new List<Snack>();
        private decimal _revenue;

        public SnackBar() { _revenue = 0; }

        public SnackBar(Snack snack1)
        {
            _snacksMenu.Add(snack1);
            _revenue = 0;
        }

        public SnackBar(Snack snack1, Snack snack2)
        {
            _snacksMenu.Add(snack1);
            _snacksMenu.Add(snack2);
            _revenue = 0;
        }

        public SnackBar(Snack snack1, Snack snack2, Snack snack3)
        {
            _snacksMenu.Add(snack1);
            _snacksMenu.Add(snack2);
            _snacksMenu.Add(snack3);
            _revenue = 0;
        }

        public void AddToMenu(Snack snack)
        {
            _snacksMenu.Add(snack);
        }

        public decimal ProcessOrder(List<string> itemNames, List<int> itemQuantities)
        {
            decimal price = 0;

            for (int i = 0; i < itemQuantities.Count; i++)
            {
                var snack = findSnackThroughName(itemNames[i]);
                if (snack.DecreaseStock(itemQuantities[i]))
                {
                    price += snack.GetPrice() * itemQuantities[i];
                }
                else
                {
                    for (int y = i - 1; y >= 0; y--)
                    {
                        var snackReverse = findSnackThroughName(itemNames[y]);
                        snackReverse.IncreaseStock(itemQuantities[y]);
                    }
                    price += i * -1;
                    break;
                }
            }
            if (price > 0) { _revenue += price; }
            return price;
        }

        public Snack findSnackThroughName(string name)
        {
            foreach (var snack in _snacksMenu)
            {
                if (snack.GetName() == name)
                {
                    return snack;
                }
            }
            return null;
        }

        public List<Snack> GetSnacks()
        {
            return _snacksMenu;
        }

        public void EditSnack(string name, decimal price, int stock)
        {
            var snack = findSnackThroughName(name);
            if (snack != null)
            {
                snack.EditSnack(price, stock);
            }
        }

        public void EditSnack(string name, decimal price, int stock, string description)
        {
            var snack = findSnackThroughName(name);
            if (snack != null) 
            {
                snack.EditSnack(price, stock, description);
            }
        }

        public void DeleteSnack(string name)
        {
            var snack = findSnackThroughName(name);
            if (snack != null)
            {
                _snacksMenu.Remove(snack);
            }
        }

        public decimal GetRevenue()
        {
            return _revenue;
        }
    }
}
