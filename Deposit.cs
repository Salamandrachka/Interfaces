using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
  
        public abstract class Deposit : IComparable <Deposit>
        {
            private decimal amount;
            private int period;

            public decimal Amount
            {
                get { return amount; }
            }

            public decimal Period
            {
                get { return period; }
            }


            public Deposit(decimal depositAmount, int depositPeriod)
            {
                amount = depositAmount;
                period = depositPeriod;
            }

            public int CompareTo(Deposit obj)
            {
              if (obj == null) return 1;

              return Decimal.Compare(obj.Income(), this.Income());
            }

            public abstract decimal Income();

        }
}
