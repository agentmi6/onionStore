using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public abstract class BaseEntitiy
    {
        public int ID { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
