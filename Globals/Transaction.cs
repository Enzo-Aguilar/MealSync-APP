using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Globals
{
    public class Transaction
    {
        public int ID { get; set; } = -1;
        public int ID_Holder { get; set; } = -1;
        public SqlMoney Amount { get; set; } = SqlMoney.Zero;
        public DateTime DateTime { get; set; } = DateTime.MinValue;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public void Clear() 
        {
            ID = -1;
            ID_Holder = -1;
            Amount = SqlMoney.Zero;
            DateTime = DateTime.MinValue;
            Description = string.Empty;
            Type = string.Empty;
        }
    }
}
