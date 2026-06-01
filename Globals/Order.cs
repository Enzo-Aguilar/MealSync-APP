using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Globals
{
    public class Order
    {
        public int ID {  get; set; }
        public int ID_Meal { get; set; }
        public int ID_Transaction { get; set; }
        public int ID_User { get; set; }
        public DateTime BookedAt {  get; set; }
    }
}
