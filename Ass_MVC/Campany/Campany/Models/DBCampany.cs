using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Campany.Models
{
    public class DBCampany : DbContext
    {
        public DBCampany(DbContextOptions<DBCampany> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7EGMHQLE\\SQLEXPRESS;Initial Catalog=Company_MVC;User ID=sa;Password=123456;Encrypt=False");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>(entity => {
                entity.HasKey(k => k.Id);
            });
        }
    }
}
