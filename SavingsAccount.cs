using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }


        public SavingsAccount(string owner, decimal interestRate) : base(owner + "(" + interestRate + " %)") // constructor that inherits properties from BankAccount
        {
            InterestRate = interestRate;

        }



        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You can not deposit $" + amount;
            if (amount > 20000)
                return "AML deposit limit has been reached.";

            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount + interestAmount;
            return "Deposit completed sucessfully!";
        }
    }
}
