using System.Data.SqlTypes;
using System;

namespace MealSync_APP.Globals
{
    public class Meal
    {
        private const int InvalidId = -1;

        public int ID { get; set; } = InvalidId;
        public DateTime? Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public byte[] MealImage { get; set; } = Array.Empty<byte>();
        public string Name { get; set; } = string.Empty;
        public SqlMoney Price { get; set; } = SqlMoney.Zero;
        public string Type { get; set; } = string.Empty;
        public Meal Clear()
        {
            return new Meal();
        }
    }
}