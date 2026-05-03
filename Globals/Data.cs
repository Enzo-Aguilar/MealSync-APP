using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Globals
{
    public class Data
    {
        public static User CurrentUser { get; set; } = new User();
        public static List<BankAccount> UserBankAccounts { get; set; } = new List<BankAccount>();
    }
}