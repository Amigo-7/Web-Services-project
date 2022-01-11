using AstanovWebApp.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstanovWebApp.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Web> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Desktop-432f1ub/Mike; Initial Catalog=webapp;Persist Security Info=True;User ID=As;password=Amir22;");
        }
    }
}
