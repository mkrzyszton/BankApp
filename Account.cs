using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankApp
{
    public class Account
    {
        protected readonly StringBuilder AccountNumber;
        protected Guid AccountId;
        protected AccountCurrencyEnum AccountCurrency;
        protected decimal AccountBalance;
        protected bool AccountBlockade;

        public Account()
        {
            AccountId = Guid.NewGuid();
            AccountNumber = new AccountNumberGenerator().Generate();
            AccountBlockade = false;
        }

        public void Display()
        {
            Console.WriteLine($"{AccountNumber};{AccountId};{AccountCurrency};{AccountBalance};{AccountBlockade}");
        }
    }
}