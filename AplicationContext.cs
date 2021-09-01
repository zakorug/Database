using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database
{
    class AplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AplicationContext() : base("DefaultConnection") { }
    }
}
