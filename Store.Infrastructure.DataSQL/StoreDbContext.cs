using Store.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Store.Infrastructure.DataSQL
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext() : base("name=storeSQLDbConnection")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Domain.Store> Stores { get; set; }
    }
}
