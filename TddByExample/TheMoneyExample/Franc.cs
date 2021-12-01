using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyExample 
{
    public class Franc : IEquatable<Franc>
    {
        private readonly int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }
        public bool Equals(Franc? other)
        {
            return amount == other?.amount;
        }
    }
}