using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation;

namespace Banking
{
    public class Account
    {
        public event Operation underBalance, overBalance;

        public double Balance { get; set; }

        public Account(double initialAmount)
        {
            this.Balance = initialAmount;
        }
        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if (result <= 10000)
            {
                // raise an event : underBalance
                underBalance(11);
            }
            Balance = result;
        }

        public void Deposit(double amount)
        {

            Balance += amount;

            if (Balance > 350000)

            {
                //raise an event : overBalance
                overBalance(23);

            }

        }
    }
}
