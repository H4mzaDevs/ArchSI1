using Microsoft.EntityFrameworkCore;

namespace AM.Infrastructure
{
    public class AMContext  : DbContext
    {
        //public DbSet<Flight> Customers { get; set; }//
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}