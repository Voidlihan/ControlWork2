using System;
using System.Collections.Generic;
using System.Text;

namespace ControlWork2.Models
{
    public abstract class Entity
    {
        public Guid ID { get; set; } = Guid.NewGuid();        

    }
}
