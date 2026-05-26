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
        public int ID { get; set; }
        public string Description { get; set; }
        public string bool IsActive { get; set; }
        public byte[] MealImage { get; set; }
        public string Name { get; set; }
        public SqlMoney Price { get; set; }
        public string Type { get; set; }
    }
}
