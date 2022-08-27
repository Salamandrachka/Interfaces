using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
        public class Client: IEnumerable <Deposit>
        {
            private Deposit[] deposits;

            public Client()
            {
                this.deposits = new Deposit[10];
            }

            public bool AddDeposit(Deposit deposit)
            {
                for (int i = 0; i < deposits.Length; i++)
                {
                    if (deposits[i] == null)
                    {
                        deposits[i] = deposit;
                        return true;
                    }
                }
                return false;
            }

            public decimal TotalIncome()
            {
                decimal sum = 0;
                for (int i = 0; i < deposits.Length; i++)
                {
                    if (deposits[i] != null)
                    {
                        sum += deposits[i].Income();
                    }
                }
                return sum;
            }

            public decimal MaxIncome()
            {
                decimal max = 0;
                for (int i = 0; i < deposits.Length; i++)
                {
                    if (deposits[i] != null && deposits[i].Income() > max)
                    {
                        max = deposits[i].Income();
                    }
                }
                return max;
            }

            public decimal GetIncomeByNumber(int number)
            {
                Deposit deposit = deposits[number - 1];
                if (deposit == null)
                {
                    return 0;
                }
                return deposit.Income();
            }

            public IEnumerator<Deposit> GetEnumerator()
            {
                return ((IEnumerable<Deposit>)deposits).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return deposits.GetEnumerator();
            }

            public void SortDeposits()
            {
            Array.Sort(deposits, (x, y) => y.CompareTo(x)); 
            }

            public int CountPossibleToProlongDeposit()
            {
                int count = 0;
                foreach (Deposit deposit in deposits)
                {
                    IProlongable depositProlongable = deposit as IProlongable;
                    if (depositProlongable != null && depositProlongable.CanToProlong())
                    {
                        count++;
                    }
                }
                return count;
            }
        }
}
