using System.Security.Cryptography;

namespace BankApp;

public class AccountNumberGenerator : Random
{
   private int Number
   {
      get => Next(0, 10);
   }

   public AccountNumberGenerator()
   {
      for (int i = 0; i < 11; i++)
      {
         Console.Write(Number);
      }
   }
}