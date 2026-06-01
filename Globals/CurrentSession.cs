using System.Collections.Generic;
using System.Data;

namespace MealSync_APP.Globals
{
    public class CurrentSession
    {
        public static User User { get; set; } = new User();
        public static DataTable UserBkAccountsDataTable = new DataTable();
    }
}