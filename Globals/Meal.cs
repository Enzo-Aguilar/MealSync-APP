using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Globals
{
    public class Meal
    {
        public int ID { get; set; } = -1;
        public DateTime Date { get; set; } = DateTime.MinValue;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public byte[] MealImage { get; set; } = new byte[0];
        public string Name { get; set; } = string.Empty;
        public SqlMoney Price { get; set; } = SqlMoney.Zero;
        public string Type { get; set; } = string.Empty;

        public void Clear()
        {
            ID = -1;
            Date = DateTime.MinValue;
            Description = string.Empty;
            IsActive = false;
            MealImage = new byte[0];
            Name = string.Empty;
            Price = SqlMoney.Zero;
            Type = string.Empty;
        }
    }
}
