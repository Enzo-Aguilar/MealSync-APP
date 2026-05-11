using System.Collections.Generic;

namespace MealSync_APP.Globals
{
    public class CurrentSession
    {
        public static User User { get; set; } = new User();

        public static List<BankAccount> UserBkAccountsList = new List<BankAccount>();
    }
}