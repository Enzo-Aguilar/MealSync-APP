using System;

namespace MealSync_APP.Globals
{
    public class BankAccount
    {
        public int ID { get; set; } = -1;
        public string AccountType { get; set; }
        public decimal Balance { get; set; } = 0m;
        public DateTime? CreatedAt { get; set; }
        public string Iban { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public string Password { get; set; } = string.Empty;

        public BankAccount Clear()
        {
            return new BankAccount();
        }
    }
    public class Iban
    {
        public static string Create()
        {
            string Iban = "PT50";
            Random random = new Random();
            for (int i = 0; Iban.Length < 25; i++)
            {
                Iban += random.Next(0, 10).ToString();
            }
            return Iban;
        }
    }
}
