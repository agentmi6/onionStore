using Store.Domain.Intefraces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.DataSQL
{
    public class UserRepository : IUserRepository
    {
        StoreDbContext db = new StoreDbContext();

        public void Create(Domain.User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
