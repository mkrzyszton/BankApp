﻿using System.Text;
using BankApp;


namespace BankApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user = new("Mariusz", "Pudzian", 12345312311, "Krakow", "ul. Jasia 16",
                AccountCurrencyEnum.PLN, 1259);
            Account account = new();

            user.Display();
            account.Display();
        }
    }
}