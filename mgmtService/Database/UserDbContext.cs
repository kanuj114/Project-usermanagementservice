using System;
using mgmtService.Model;
using Microsoft.EntityFrameworkCore;


namespace mgmtService.Database
{
    public class UserDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Kamlakar\\SQLEXPRESS;Initial Catalog=Usermgmt_DB;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
        }

        public DbSet<User> users{get;set;}

        public DbSet<Product> products{get;set;}
    }
}