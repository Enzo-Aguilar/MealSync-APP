using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP.Globals
{
    public class Holder
    {
        public int ID { get; set; }
        public int ID_User { get; set; }
        public int ID_BankAccount { get; set; }
        public bool IsActive { get; set; }
        public int OwnershipOrder { get; set; }
    }
}
