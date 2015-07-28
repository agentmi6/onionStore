using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class User : BaseEntitiy
    {        
        public string Username { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }
       
    }
}
