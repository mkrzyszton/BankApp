using System.Security.Cryptography;
using System.Text;

namespace BankApp;

public class AccountNumberGenerator : Random
{
   private readonly StringBuilder _stringBuilder = new();
   private int Number => Next(0, 10);

   public string Generate()
   {
      for (int i = 0; i < 11; i++)
      {
         _stringBuilder.Append(Number);
      }

      return _stringBuilder.ToString();
   }
}