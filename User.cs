using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class User : Account
    {
        private readonly Guid _userId;
        private readonly string _userForename;
        private readonly string _userSurname;
        private readonly long _userPesel;
        private readonly string _userCity;
        private readonly string _userAddress;

        public User(string userForename, string userSurname, long userPesel, string userCity, string userAddress,
            AccountCurrencyEnum accountCurrency, decimal accountBalance)
        {
            _userId = Guid.NewGuid();
            _userForename = userForename;
            _userSurname = userSurname;
            _userPesel = userPesel;
            _userCity = userCity;
            _userAddress = userAddress;

            AccountCurrency = accountCurrency;
            AccountBalance = accountBalance;
            AccountBlockade = false;
        }

        public void Display()
        {
            Console.WriteLine($"{_userId};{_userForename};{_userSurname};{_userPesel};{_userCity};{_userAddress}");
        }
        
        public decimal PayIn(decimal deposit)
        {
            AccountBalance += deposit;
            return AccountBalance;
        }
        
        public decimal PayOut(decimal draw)
        {
            AccountBalance -= draw;
            return AccountBalance;
        }

        public bool BlockAccount()
        {
            AccountBlockade = true;
            return AccountBlockade;
        }
        public bool UnBlockAccount()
        {
            AccountBlockade = false;
            return AccountBlockade;
        }
    }
}
