using Microsoft.EntityFrameworkCore;
using ProjectJWT.Model.Entitys;
using System.Reflection;

namespace ProjectJWT.Model.context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* optionsBuilder.UseSqlServer(@"Server=.;Database=Bahar;User Id=sa;Password=Mahanan1377.;");*/
            optionsBuilder.UseSqlServer(@"Server=.;Database=Jwt;User Id=sa;Password=Mahanan1377.;");
        }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
