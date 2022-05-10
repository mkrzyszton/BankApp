using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Reader
    {
        private readonly string userPath = @"D:/Programowanie/csharp/console/BankApp/BankApp/osoby.csv";
        private readonly string accountPath = @"D:/Programowanie/csharp/console/BankApp/BankApp/konta.csv";

        public void UserFile()
        {
            List<string> readText = new List<string>(File.ReadLines(userPath));

            readText.ForEach(e => Console.WriteLine(e));
        }
        
        public void AccountFile()
        {
            List<string> readText = new List<string>(File.ReadLines(accountPath));
            
            readText.ForEach(e => Console.WriteLine(e));
        }
    }
}
