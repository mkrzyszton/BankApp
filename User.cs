using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class User
    {
        // public readonly Guid UserId;
        public int UserId;
        private readonly string _userForename;
        private readonly string _userSurname;
        private readonly long _userPesel;
        private readonly string _userCity;
        private readonly string _userAddress;

        public User(int userId, string userForename, string userSurname, long userPesel, string userCity, string userAddress)
        {
            // UserId = Guid.NewGuid();
            UserId = userId;
            _userForename = userForename;
            _userSurname = userSurname;
            _userPesel = userPesel;
            _userCity = userCity;
            _userAddress = userAddress;
        }

        public void Display()
        {
            Console.WriteLine($"{UserId};{_userForename};{_userSurname};{_userPesel};{_userCity};{_userAddress}");
        }

        public void DisplayAllAccounts()
        {
            Program.accountList.Where(e => e.UserId == UserId).ToList().ForEach(e => e.Display());
        }
    }
}
