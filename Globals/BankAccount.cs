using System.Data.SqlTypes;
using System;
using MealSync_APP.Utils;

namespace MealSync_APP.Globals
{
    public class BankAccount
    {
        public int ID { get; set; }
        public string AccountType { get; set; }
        public SqlMoney Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Iban { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }

        public void Clear()
        {
            ID = -1; 
            AccountType = string.Empty;
            Balance = -1;
            CreatedAt = DateTime.MinValue;
            Iban = string.Empty;
            IsActive = false;
            Password = string.Empty;
        }
    }
    public class Iban
    {
        static public string Create()
        {
            string Iban = "PT50";
            Random random = new Random();
            for(int i = 0; Iban.Length < 25; i++)
            {
                Iban += random.Next(0, 10).ToString();
            }
            return Iban;
        }
    }
}
