using System.Data.SqlTypes;
using System;
using System.Windows.Forms;

namespace MealSync_APP
{
    public class User
    {
        public int ID { get; set; }
        public DateTime createdAt { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public int role { get; set; }
        public string schoolID_num { get; set; }
        public string postalCode { get; set; }
    }
}
