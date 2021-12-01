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
        public string Currency { get; protected set; }

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.Currency = currency;
        }

        public abstract Money times(int multiplier);

        public static Dollar dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public bool Equals(Money obj)
        {
            return amount == obj?.amount && this.GetType().Equals(obj.GetType());
        }
    }
}