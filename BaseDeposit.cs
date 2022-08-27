using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    using System;

        public class BaseDeposit : Deposit
        {
           
            public BaseDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod)
            {
            }

            public override decimal Income()
            {
                decimal sum = base.Amount;
                for (int i = 1; i <= base.Period; i++)
                {
                    sum *= (1 + 5M / 100);
                }
                return Math.Round(sum - base.Amount, 2);
            }
        }
}
