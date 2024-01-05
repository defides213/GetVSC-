﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount 
{
    public class SavingAccount : Account
    {
        public SavingAccount(int accountID, int balance) : base(accountID, balance) {}

        public override void Withdraw(int amount)
        {
            if(Balance >= 100 || amount < 1000){ Console.WriteLine("No"); }
            else { Balance -= amount; }
        }
    }

}
