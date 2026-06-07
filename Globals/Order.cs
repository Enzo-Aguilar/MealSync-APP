using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Globals
{
    public class Order
    {
        public int ID { get; set; } = -1;
        public int ID_Meal { get; set; } = -1;
        public int ID_Transaction { get; set; } = -1;
        public int ID_User { get; set; } = -1;
        public DateTime BookedAt { get; set; } = DateTime.MinValue;
        public void Clear()
        {
            ID = -1;
            ID_Meal = -1;
            ID_Transaction = -1;
            ID_User = -1;
            BookedAt = DateTime.MinValue;
        }
    }
}
