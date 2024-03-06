using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_Day3___Serializing_Objects
{
    [Serializable]
    public class Sandwich
    {
        private string _name;
        private double _basePrice;
        private BreadType _bread;
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Sandwich(string name, double basePrice, BreadType bread)
        {
            _name = name;
            _basePrice = basePrice;
            _bread = bread;
        }

        public string Name { get => _name; set => _name = value; }
        
        public BreadType Bread { get => _bread; set => _bread = value; }
        
        public void AddIngredient(Ingredient i)
        {
            if (_ingredients.Count <= 5)
            {
                _ingredients.Add(i);
            }
        }

        public string GetInfo()
        {
            string s = $"{_name} ({_bread} with";
            foreach (Ingredient i in _ingredients)
            {
                s += " " + i.Name;
            }
            s += ")";
            return s;
        }

        public double GetPrice()
        {
            return _basePrice + _ingredients.Sum(i => i.Price);
        }

        public override string? ToString()
        {
            return Name;
        }
    }
}
