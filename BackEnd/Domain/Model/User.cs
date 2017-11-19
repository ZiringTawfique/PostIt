using System;

namespace Domain.Model
{
    public class User
    {
        public string Username { get; set ;}
        public string Email { get; set; }
        public string Address { get; set; }
        public int TeleNumber { get; set; }
        public Organisation Organisation { get; set; }
    }
}
