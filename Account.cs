using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        protected AccountNumberGenerator? AccountNumber;
        //generator
        protected int AccountId = 2;
        protected static AccountCurrencyEnum AccountCurrency;
        protected static decimal AccountBalance;
        protected bool AccountBlockade;

        public void Display(int accountId)
        {
            AccountId = accountId;
            
            Console.WriteLine($"{AccountNumber};{AccountId};{AccountCurrency};{AccountBalance};{AccountBlockade}");
        }
    }
}