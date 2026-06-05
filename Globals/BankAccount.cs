using System.Data.SqlTypes;
using System;

namespace MealSync_APP.Globals
{
    public class BankAccount
    {
        public int ID { get; set; }
        public string AccountType { get; set; }
        public SqlMoney Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public string IBAN { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }

        public void Reset()
        {
            ID = -1; 
            AccountType = string.Empty;
            Balance = -1;
            CreatedAt = DateTime.MinValue;
            IBAN = string.Empty;
            IsActive = false;
            Password = string.Empty;
        }
    }
    public class IBAN
    {
        static public string Create()
        {
            string IBAN = "PT50";
            Random random = new Random();
            for(int i = 0; IBAN.Length < 25; i++)
            {
                IBAN += random.Next(0, 10).ToString();
            }
            return IBAN;
        }
    }
}
