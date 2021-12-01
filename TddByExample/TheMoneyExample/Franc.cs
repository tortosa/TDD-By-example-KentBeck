﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyExample
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money times(int multiplier)
        {
            return Money.franc(amount * multiplier);
        }
    }
}