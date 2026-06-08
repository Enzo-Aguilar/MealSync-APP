using System;

namespace MealSync_APP
{
    public class User
    {
        private const int _StudentRole = 2;
        public int ID { get; set; } = -1;
        public DateTime? CreatedAt { get; set; }
        public string Email { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public byte[] ProfileImage { get; set; } = Array.Empty<byte>();
        public int Role { get; set; } = _StudentRole;
        public string SchoolIDNumber { get; set; } = string.Empty;

        public User Clear()
        {
            return new User();
        }
    }
}
