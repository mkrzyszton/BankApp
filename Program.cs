using System.Text;
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
            Reader reader = new();

            Console.WriteLine();
            user.Display();
            Console.WriteLine("\n --------------------------------------- \n");
            account.Display();
            Console.WriteLine("\n --------------------------------------- \n");
            reader.UserFile();
            Console.WriteLine("\n --------------------------------------- \n");
            reader.AccountFile();
        }
    }
}