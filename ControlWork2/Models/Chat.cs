using System;
using System.Collections.Generic;
using System.Text;

namespace ControlWork2.Models
{
    public class Chat : Entity
    {
        public ICollection<User> Users { get; set; }
        public ICollection<Sms> SMS { get; set; }
    }
}
