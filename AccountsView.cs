namespace BankApp;

public class AccountsView
{
    public static List<Account> accountList = new();

    public void DisplayAccounts()
    {
            accountList.ForEach(e => e.Display());
    }
    
    public void BlockedAccounts()
    {
           accountList.Where(e => e.AccountStatus()).ToList().ForEach(e => e.Display());
    }
    
    public void NotBlockedAccounts()
    {
           accountList.Where(e => e.AccountStatus() == false).ToList().ForEach(e => e.Display());
    }
}