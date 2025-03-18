using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using Microsoft.EntityFrameworkCore;

namespace PatikaCodeFirstProject
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
        }
    }
}
