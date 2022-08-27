using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    using System;


        public class LongDeposit : Deposit, IProlongable
        {
            public LongDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount, depositPeriod)
            {
            }

            public bool CanToProlong()
            {
                return Period <= 36;
            }
            public override decimal Income()
            {
                decimal sum = Amount;
                for (int i = 7; i <= Period; i++)
                {
                    sum *= (1 + 15M / 100);
                }
                return Math.Round(sum - Amount, 2);
            }
        }
}
