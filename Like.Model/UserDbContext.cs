using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
