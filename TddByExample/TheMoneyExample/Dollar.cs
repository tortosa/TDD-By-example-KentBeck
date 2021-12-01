using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyExample 
{
    public class Dollar : IEquatable<Dollar>
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
        public bool Equals(Dollar? other)
        {
            return amount == other?.amount;
        }
    }
}