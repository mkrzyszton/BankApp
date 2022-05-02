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
        private readonly StringBuilder _accountNumber;
        private readonly Guid _accountId;
        protected AccountCurrencyEnum AccountCurrency;
        protected decimal AccountBalance;
        protected bool AccountBlockade;

        public Account()
        {
            _accountId = Guid.NewGuid();
            _accountNumber = new AccountNumberGenerator().Generate();
            AccountBlockade = false;
        }

        public void Display()
        {
            Console.WriteLine($"{_accountNumber};{_accountId};{AccountCurrency};{AccountBalance};{AccountBlockade}");
        }
    }
}