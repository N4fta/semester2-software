using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_Day3___Serializing_Objects
{
    [Serializable]
    public class Bakery
    {
        private const int VAT_PERCENTAGE = 9;
        private string _name;
        private List<Sandwich> _offeredSandwiches = new List<Sandwich>();
        private List<Sandwich> _sold = new List<Sandwich>();
        private List<Ingredient> _availableIngredients = new List<Ingredient>();

        public Bakery(string name)
        {
            _name = name;

            // Ingredients
            _availableIngredients.Add(new Ingredient("Cucumber", 0.05));
            _availableIngredients.Add(new Ingredient("Tomato", 0.15));
            _availableIngredients.Add(new Ingredient("Cheddar", 0.2));
            _availableIngredients.Add(new Ingredient("Ham", 0.15));
            _availableIngredients.Add(new Ingredient("Chorizo", 0.25));
            _availableIngredients.Add(new Ingredient("Apple", 0.1));
            _availableIngredients.Add(new Ingredient("Tuna", 0.2));
            _availableIngredients.Add(new Ingredient("Smoked Salmon", 0.4));
            _availableIngredients.Add(new Ingredient("Cream cheese", 0.15));
            _availableIngredients.Add(new Ingredient("Gouda cheese", 0.1));

        }

        public string Name { get => _name; }

        public void AddSandwich(Sandwich s)
        {
            _offeredSandwiches.Add(s);
        }

        public Ingredient[] GetAvailableIngredients()
        {
            return _availableIngredients.ToArray();
        }
        
        public Sandwich[] GetAvailableSandwiches()
        {
            return _offeredSandwiches.ToArray();
        }

        public Sandwich[] GetAvailableSandwiches(BreadType bread)
        {
            return _offeredSandwiches.Where(sandwich => sandwich.Bread == bread).ToArray();
        }

        public double SellSandwich(Sandwich s)
        {
            _sold.Add(s);
            return s.GetPrice()+ s.GetPrice()*0.09;
        }

        public double CalculateRevenue(bool includeVAT)
        {
            double revenue = _sold.Sum(s=>s.GetPrice());
            if (includeVAT)
            {
                revenue = revenue + revenue * 0.09;
            }
            return revenue;
        }
    }
}
