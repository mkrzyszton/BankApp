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
        private readonly string _accountNumber;
        public readonly int UserId;
        private readonly AccountCurrencyEnum _accountCurrency;
        private decimal _accountBalance;
        private bool _accountBlockade;
        private string accountBlockadeStatus(bool status) => status ? "TAK" : "NIE";

        public Account(User userId, AccountCurrencyEnum accountCurrency, decimal accountBalance)
        {
            _accountCurrency = accountCurrency;
            _accountBalance = accountBalance;
            UserId = userId.UserId;
            _accountNumber = new AccountNumberGenerator().Generate();
            _accountBlockade = false;
        }

        public void Display()
        {
            Console.WriteLine($"{_accountNumber};{UserId};{_accountCurrency};{_accountBalance};{accountBlockadeStatus(_accountBlockade)}");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"{UserId}: {_accountBalance} {_accountCurrency}");
        }

        public decimal PayIn(decimal deposit)
        {
            _accountBalance += deposit;
            return _accountBalance;
        }

        public decimal PayOut(decimal draw)
        {
            _accountBalance -= draw;
            return _accountBalance;
        }

        public bool BlockAccount()
        {
            _accountBlockade = true;
            return _accountBlockade;
        }

        public bool UnblockAccount()
        {
            _accountBlockade = false;
            return _accountBlockade;
        }

        public bool AccountStatus()
        {
            return _accountBlockade;
        }
    }
}