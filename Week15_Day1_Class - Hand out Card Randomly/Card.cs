using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_out_Card_Randomly
{
    public class Card
    {
        private int _number;

        public Card(int number)
        {
            Number = number;
        }

        public int Number { get => _number; set => _number = value; }
    }
}
