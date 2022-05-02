using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class User : Account
    {
        private int userId;
        // User
        private string userForename;
        // User
        private string userSurname;
        //max char(11), gen
        private long userPesel;
        //enum
        private string userCity;
        private string userAddress;

        public User(int userId, string userForename, string userSurname, long userPesel, string userCity, string userAddress,
            AccountCurrencyEnum AccountCurrency, decimal AccountBalance)
        {
            this.userId = userId;
            this.userForename = userForename;
            this.userSurname = userSurname;
            this.userPesel = userPesel;
            this.userCity = userCity;
            this.userAddress = userAddress;
            Account.AccountCurrency = AccountCurrency;
            Account.AccountBalance = AccountBalance;
            AccountNumber = new AccountNumberGenerator();
            AccountId = userId;
            AccountBlockade = false;
        }

        public void Display()
        {
            Console.WriteLine($"{userId};{userForename};{userSurname};{userPesel};{userAddress}");
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

        public bool BlockAccount(bool status)
        {
            AccountBlockade = status;
            return AccountBlockade;
        }
    }
}
