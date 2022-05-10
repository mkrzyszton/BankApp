using System.Text;
using BankApp;


namespace BankApp
{
    class Program
    {
        public static List<Account> accountList = new();
        public static void Main(string[] args)
        {
            Reader reader = new();
            User user = new( 1,"Mariusz", "Pudzian", 12345312311, "Krakow", "ul. Jasia 16");
            User user2 = new( 2,"Dariusz", "Szpakowski", 12345312311, "Bydgoszcz", "ul. Maklowicza 92");
            Account account = new Account(AccountCurrencyEnum.PLN, 1299, user);
            Account account2 = new Account(AccountCurrencyEnum.USD, 6399, user2);
            Account account3 = new Account(AccountCurrencyEnum.EUR, 399, user);

            account2.BlockAccount();
            account3.PayIn(500);
            account3.BlockAccount(); 
            
            accountList.Add(account);
            accountList.Add(account2);
            accountList.Add(account3);

            user.DisplayAllAccounts();
            
            Console.WriteLine();
            user.Display();
            Console.WriteLine("\n --------------------------------------- \n");
            accountList.ForEach(e => e.Display());
            Console.WriteLine("\n --------------------------------------- \n");
            reader.UserFile();
            Console.WriteLine("\n --------------------------------------- \n");
            reader.AccountFile();
        }
    }
}