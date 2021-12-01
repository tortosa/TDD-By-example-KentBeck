using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyExample 
{
    public class Money
    {
        public int amount;

        public bool Equals(Money obj)
        {
            return amount == obj?.amount && this.GetType().Equals(obj.GetType());
        }
    }
}