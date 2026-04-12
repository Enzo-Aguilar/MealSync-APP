using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP
{
    internal class Globals
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
}
