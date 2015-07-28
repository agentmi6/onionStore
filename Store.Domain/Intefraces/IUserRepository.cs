using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Intefraces
{
    public interface IUserRepository
    {
        void Create(User user);

        void Delete(int id);
    }
}
