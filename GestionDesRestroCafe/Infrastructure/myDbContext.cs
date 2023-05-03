using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class myDbContext : DbContext
    {
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<LigneCommande> LignesCommande { get; set; }
        public DbSet<Livreur> Livreurs { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Plat> Plats { get; set; }

        public DbSet<LigneCommande> LigneCommande { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AirportManagementDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Commande>().HasKey(c => c.NumCmd);
            modelBuilder.Entity<Livreur>().HasKey(l => l.Id);
            modelBuilder.Entity<Menu>().HasKey(m => m.Id);
            modelBuilder.Entity<Plat>().HasKey(p => p.IdPlat);
            modelBuilder.Entity<LigneCommande>().HasKey(lc => lc.Id);


            modelBuilder.Entity<Commande>()
                .HasMany(c => c.Plats)
                .WithMany(p => p.Commandes)
                .UsingEntity(j => j.ToTable("CommandePlat"));

            
            modelBuilder.Entity<Menu>()
                .HasMany(m => m.Plats)
                .WithMany(p => p.Menus)
                .UsingEntity(j => j.ToTable("MenuPlat"));

            
            modelBuilder.Entity<LigneCommande>()
                .HasOne(lc => lc.Plat)
                .WithMany(p => p.LignesCommande)
                .HasForeignKey(lc => lc.PlatId)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<LigneCommande>()
                .HasOne(lc => lc.Commande)
                .WithMany(c => c.LignesCommande)
                .HasForeignKey(lc => lc.NumCmd)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<Commande>()
                .HasOne(c => c.Livreur)
                .WithMany(l => l.Commandes)
                .HasForeignKey(c => c.LivreurId)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<Livreur>()
                .Property(l => l.Status)
                .HasConversion<int>();

            
            modelBuilder.Entity<Commande>()
                .Property(c => c.DateCmd)
                .HasColumnName("Date Commande");

            modelBuilder.Entity<Commande>()
                .HasMany(c => c.LignesCommande)
                .WithOne(lc => lc.Commande)
                .HasForeignKey(lc => lc.NumCmd)
                .OnDelete(DeleteBehavior.Cascade);







        }
    }
}
