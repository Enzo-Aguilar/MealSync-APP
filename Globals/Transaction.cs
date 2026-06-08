using System.Data.SqlTypes;
using System;

namespace MealSync_APP.Globals
{
    public class Transaction
    {
        private const int _InvalidId = -1;
        public int ID { get; set; } = _InvalidId;
        public int HolderId { get; set; } = _InvalidId;
        public SqlMoney Amount { get; set; } = SqlMoney.Zero;
        public DateTime? DateTime { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public Transaction Clear() 
        {
            return new Transaction();
        }
    }
}
