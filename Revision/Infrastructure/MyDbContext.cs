using Microsoft.EntityFrameworkCore;
using ApplicationCore.Domain;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Infrastructure
{
    public class MyDbContext : DbContext
    {
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SeatPassenger> SeatPassengers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AirportManagementDB;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seat>()
                .HasOne(s => s.Plane)
                .WithMany(p => p.Seats)
                .HasForeignKey(s => s.PlaneId);

            modelBuilder.Entity<Seat>()
                .HasOne(s => s.Section)
                .WithMany(sec => sec.Seats)
                .HasForeignKey(s => s.SectionId);

            modelBuilder.Entity<SeatPassenger>()
                .HasKey(sp => new { sp.SeatId, sp.PassengerId });

            modelBuilder.Entity<SeatPassenger>()
                .HasOne(sp => sp.Seat)
                .WithMany(s => s.SeatPassengers)
                .HasForeignKey(sp => sp.SeatId);

            modelBuilder.Entity<SeatPassenger>()
                .HasOne(sp => sp.Passenger)
                .WithMany(p => p.SeatPassengers)
                .HasForeignKey(sp => sp.PassengerId);


            modelBuilder.Entity<Reservation>().HasNoKey();
        }
    }
}
