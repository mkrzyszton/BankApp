using BankApp;

class Program
{
    public static void Main(string[] args)
    {
        //Nr konta;Uzytkownik;Waluta;Saldo;Blokada
        // 1;Jan;Nowak;3123451233;Krakow, ul. Starowislna 6
        User user = new(2,  "Mariusz", "Pudzian",  12345312311,  "Krakow", "ul. Jasia 16", 
            AccountCurrencyEnum.PLN, 1259);
        Account account = new();
        
        account.Display(2);
    }
}
