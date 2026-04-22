using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    internal class BankAccount
    {
        private decimal _balance;
        public decimal balance
        {
            get { return _balance; }
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0) {
                this._balance = balance + amount;
                Console.WriteLine("New Balance" + balance);
            }
            else
            {
                Console.WriteLine("the amount should be positive");
            }
        }
        public void Withdraw(decimal amount) {

            if (amount < 0)
            {
                Console.WriteLine("the amount should be positive");
            }
            else if (amount > _balance) {

                Console.WriteLine("the amount out of range more than balance ");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine("the Balnace is "+_balance);
            }
        }
    }
}
