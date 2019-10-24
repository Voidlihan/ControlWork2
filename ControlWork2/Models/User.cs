using System;
using System.Collections.Generic;
using System.Text;

namespace ControlWork2.Models
{
    public class User : Entity
    {
        public string Log { get; set; }
        public ICollection<Sms> SMS { get; set; }
    }
}
