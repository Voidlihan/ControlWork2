using System;
using System.Collections.Generic;
using System.Text;

namespace ControlWork2.Models
{
    public class Sms
    {
        public string Text { get; set; }
        public User User { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
