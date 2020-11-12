using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace NetasEmployeeAPI.Models.DBObjects.Context
{
    public class DatabaseContext : DbContext
    {
  

        public DatabaseContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<DBEmployee> Employees { get; set; }
        public DbSet<DBEmployeeType> EmployeeTypes { get; set; }

    }
}
