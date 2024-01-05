using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class CreditAccount : Account
    {
        private int Credit;

        public CreditAccount(int accountID, int balance, int credit) : base(accountID, balance)
        {
            Credit = credit;
        }
    }
}
