using System.Text;
using BankApp;


namespace BankApp
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            AccountsView accountsView = new();
            Reader reader = new();
            User user1 = new User(1, "Jan", "Nowak", 3123451233, "Krakow", "Starowislna 6");
            User user2 = new User(2, "Anna", "Kowalska", 7254832946, "Warszawa", "Pawia 3/4");
            User user3 = new User(3, "Krystyna", "Duda", 1234142344, "Wroclaw", "Zakole 3");

            Account account1 = new Account(user1, AccountCurrencyEnum.PLN, 2324);
            Account account2 = new Account(user2, AccountCurrencyEnum.EUR, 12333);
            Account account3 = new Account(user1, AccountCurrencyEnum.PLN, 2000);
            Account account4 = new Account(user2, AccountCurrencyEnum.USD, 200);
            Account account5 = new Account(user3, AccountCurrencyEnum.PLN, 212314);
            
            account1.BlockAccount();
            account2.BlockAccount();
            account3.BlockAccount(); 
            
            AccountsView.accountList.Add(account1);
            AccountsView.accountList.Add(account2);
            AccountsView.accountList.Add(account3);
            AccountsView.accountList.Add(account4);
            AccountsView.accountList.Add(account5);

            Console.WriteLine();
            Console.WriteLine("Wypisywanie listy kont");
            user1.DisplayAllAccounts();
            Console.WriteLine("\n --------------------------------------- \n");
            Console.WriteLine("Możliwość wpłat i wypłat środków z konta");
            account3.DisplayBalance();
            account3.PayIn(500);
            account3.DisplayBalance();
            account3.PayOut(200);
            account3.DisplayBalance();
            Console.WriteLine("\n --------------------------------------- \n");
            Console.WriteLine("Wypisywanie listy zablokowanych kont");
            accountsView.BlockedAccounts();
            Console.WriteLine("\n --------------------------------------- \n");
            Console.WriteLine("Wypisywanie raportu poszczegolnych kont wraz z saldem");
            accountsView.DisplayAccounts();
            Console.WriteLine("\n --------------------------------------- \n");
            Console.WriteLine("Wczytywanie plików .csv");
            reader.UserFile();
            Console.WriteLine();
            reader.AccountFile();
        }
    }
}