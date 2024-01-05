using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public int AccountID;
        public int Balance;

        public Account(int accountID, int balance) 
        {
            AccountID = accountID;
            Balance = balance;
        }
        public virtual void Deposit(int amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(int amount)
        {
            Balance -= amount;
        }
    }

    
}
