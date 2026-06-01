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
        public int ID { get; set; }
        public int ID_Holder { get; set; }
        public SqlMoney Amount { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
