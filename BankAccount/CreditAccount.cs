using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CreditAccount : Account
    {
        public int Credit;

        public CreditAccount(int accountID, int balance, int credit) : base(accountID, balance)
        {
            Credit = credit;
        }
        public override void Withdraw(int amount)
        {
            if ( Balance <= -2000 ) { Console.WriteLine("No"); return; }
            else { Balance -= amount; }
        }
    }
}
