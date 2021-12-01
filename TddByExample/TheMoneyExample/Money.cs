using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyExample 
{
    public abstract class Money
    {
        public int amount;

        public abstract Money times(int multiplier);

        public static Dollar dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount);
        }

        public bool Equals(Money obj)
        {
            return amount == obj?.amount && this.GetType().Equals(obj.GetType());
        }
    }
}