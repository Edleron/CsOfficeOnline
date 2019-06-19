using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOnline.Entities.Concrete;
using System.Data.Entity;

namespace OfficeOnline.DataAccess.Concrete.EntityFramework
{
    public class OfficeOnlineContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
