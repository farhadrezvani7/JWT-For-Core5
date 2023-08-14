using System;
using System.Numerics;

namespace ProjectJWT.Model.Entitys
{
    public class User
    {
        public User()
        {
            CreatedDate = DateTime.Now;
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
