using Microsoft.EntityFrameworkCore;
using Ralentin.Shared.Entities;

namespace Ralentin.Backend.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) 
        {
            
        }
        public DbSet <Country>Countries { get; set; }

        //para que se unico  nombre un indece
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
