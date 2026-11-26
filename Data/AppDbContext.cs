using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_Barroc_Intens.Models;
using Microsoft.EntityFrameworkCore;

namespace E3_Barroc_Intens.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Medewerker> Medewerkers => Set<Medewerker>();
        public DbSet<Klant> Klanten => Set<Klant>();
        public DbSet<Notitie> Notities => Set<Notitie>();
        public DbSet<Product> Producten => Set<Product>();
        public DbSet<Voorraadmutatie> Voorraadmutaties => Set<Voorraadmutatie>();
        public DbSet<Offerte> Offertes => Set<Offerte>();
        public DbSet<Offerteregel> Offerteregels => Set<Offerteregel>();

        private const string ConnectionString =
            "server=localhost;port=3306;database=e3_barroc_intens;user=root;password=";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 36)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Unieke indexen
            modelBuilder.Entity<Medewerker>()
                .HasIndex(m => m.Gebruikersnaam).IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Code).IsUnique();

            // MySQL staat meerdere NULL-waarden toe in een unieke index → prospects zonder klantnummer kunnen gewoon
            modelBuilder.Entity<Klant>()
                .HasIndex(k => k.Klantnummer).IsUnique();

            // Enums als tekst opslaan (leesbaar in de database)
            modelBuilder.Entity<Medewerker>().Property(m => m.Rol).HasConversion<string>().HasMaxLength(20);
            modelBuilder.Entity<Product>().Property(p => p.Productgroep).HasConversion<string>().HasMaxLength(30);
            modelBuilder.Entity<Offerte>().Property(o => o.Status).HasConversion<string>().HasMaxLength(20);

            // Relaties met Medewerker: niet cascade-deleten
            modelBuilder.Entity<Klant>()
                .HasOne(k => k.BkrMedewerker).WithMany()
                .HasForeignKey(k => k.BkrMedewerkerId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Notitie>()
                .HasOne(n => n.Medewerker).WithMany()
                .HasForeignKey(n => n.MedewerkerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Voorraadmutatie>()
                .HasOne(v => v.Medewerker).WithMany()
                .HasForeignKey(v => v.MedewerkerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Offerte>()
                .HasOne(o => o.Medewerker).WithMany()
                .HasForeignKey(o => o.MedewerkerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Product niet verwijderen als het in een offerte of mutatie zit
            modelBuilder.Entity<Offerteregel>()
                .HasOne(r => r.Product).WithMany()
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Voorraadmutatie>()
                .HasOne(v => v.Product).WithMany()
                .HasForeignKey(v => v.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Offerteregels gaan mee weg met de offerte
            modelBuilder.Entity<Offerteregel>()
                .HasOne(r => r.Offerte).WithMany(o => o.Regels)
                .HasForeignKey(r => r.OfferteId)
                .OnDelete(DeleteBehavior.Cascade);

            SeedData.Vul(modelBuilder);

        }
    }
}
