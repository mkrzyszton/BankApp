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

        public Reader()
        {
            string[] readText = File.ReadAllLines(accountPath);

            foreach (string text in readText)
            {
                Console.WriteLine(text);
            }
        }
    }
}
