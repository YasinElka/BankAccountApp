using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; } // Guid is a data type that can hold a globally unique identifier, it is used to uniquely identify the bank account
        public decimal Balance { get; protected set; } // This property has been encapsulated.
        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid(); // Generate a new unique identifier for the bank account
            Balance = 0; // Initialize the balance to 0
        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You can not deposit $" + amount;
            if (amount > 20000)
                return "AML deposit limit has been reached.";

            Balance += amount;
            return "Deposit completed sucessfully!";
        }
        public string Withdraw(decimal amount) 
        {
            if (amount <= 0)
                return "You can not withdraw $" + amount;
            if (amount > Balance)
                return "You dont have enough money.";

            Balance -= amount;
            return "Withdraw completed sucessfully!";
        }

    }
}
