using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_Day3___Serializing_Objects
{
    [Serializable]
    public class Ingredient
    {
        private string _name;
        private double _price;

        public Ingredient(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string Name { get => _name; set => _name = value; }
        
        public double Price { get => _price; set => _price = value; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
