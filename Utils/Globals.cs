using System.Data.SqlTypes;
using System;

namespace MealSync_APP
{
    public class User
    {
        public static int ID = 0;
        public static DateTime CreatedAt = DateTime.MinValue;
        public static string Email = string.Empty;
        public static string Name = string.Empty;
        public static int Role = -1;
    }
    public class BankAccount
    {
        public static int ID = 0;
        public static SqlMoney saldo = SqlMoney.MinValue;
        public static string tipo = string.Empty;
    }
}
