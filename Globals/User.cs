using System.Data.SqlTypes;
using System;
using System.Windows.Forms;

namespace MealSync_APP
{
    public class User
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }
        public byte[] ProfileImage { get; set; } = null;
        public int Role { get; set; }
        public string SchoolIDNumber { get; set; }

        public void Clear()
        {
            ID = -1;
            CreatedAt = DateTime.MinValue;
            Email = string.Empty;
            IsActive = false;
            Name = string.Empty;
            Password = string.Empty;
            PhoneNumber = string.Empty;
            PostCode = string.Empty;
            ProfileImage = null;
            Role = -1;
            SchoolIDNumber = string.Empty;
        }
    }
}
