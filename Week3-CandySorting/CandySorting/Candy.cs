using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CandySorting
{
    class Candy : IComparable<Candy>
    {
        // Fields

        // Properties
        public double Price { get; set; }
        public string Name { get; set; }

        // Methods
        public Candy(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string GetInfo()
        {
            return $"{Name} - {Price.ToString("0.00")} e";
        }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo([AllowNull] Candy other)
        {
            if (other == null) return 1;
            int x = Price.CompareTo(other.Price);
            if (x != 0) return x;
            else return Name.CompareTo(other.Name);
        }
    }
}
