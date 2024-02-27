using CrmMVC.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Infrastructure
{
    public class CRMDbContext : IdentityDbContext<IdentityUser>
	{
        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Voivodeship> Voivodeships { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<ContactPerson> ContactPeople { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<ProductDiameter> ProductDiameters { get; set; }
        public DbSet<ProductInProject> ProductsInProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>(eb =>
            {
                eb.HasOne(c => c.Voivodeship)
                .WithMany(v => v.Companies)
                .HasForeignKey(c => c.VoivodeshipId);

                eb.HasOne(c => c.Type)
                .WithMany(ct => ct.Companies)
                .HasForeignKey(c => c.TypeId);

                eb.HasMany(c => c.ContactPeople)
                .WithOne(cp => cp.Company)
                .HasForeignKey(cp => cp.CompanyId);
            });

            builder.Entity<ContactPerson>(eb =>
            {
                eb.HasOne(cp => cp.Role)
                .WithMany(pr => pr.ContactPeople)
                .HasForeignKey(cp => cp.RoleId);
            });

            builder.Entity<Project>(eb =>
            {
                eb.Property(p => p.ShortName).HasMaxLength(32);

                eb.HasOne(p => p.Voivodeship)
                .WithMany(v => v.Projects)
                .HasForeignKey(p => p.VoivodeshipId);

                eb.HasOne(p => p.Status)
                .WithMany(ps => ps.Projects)
                .HasForeignKey(p => p.StatusId);

                eb.HasOne(p => p.Type)
                .WithMany(pt => pt.Projects)
                .HasForeignKey(p => p.TypeId);

                eb.HasOne(p => p.Contractor)
                .WithMany(c => c.InProjecAsContractor)
                .HasForeignKey(p => p.ContractorId);

                eb.HasOne(p => p.IssuingAgency)
               .WithMany(c => c.InProjecAsIssuinAgency)
               .HasForeignKey(p => p.IssuingAgencyId);

                eb.HasOne(p => p.EngineeringOffice)
               .WithMany(c => c.InProjecAsEngineeringOffice)
               .HasForeignKey(p => p.EngineeringOfficeId);
            });

            builder.Entity<Product>(eb =>
            {
                eb.HasOne(prod => prod.Unit)
                .WithMany(pu => pu.Products)
                .HasForeignKey(prod => prod.UnitId);

                eb.HasOne(prod => prod.Diameter)
                .WithMany(pu => pu.Products)
                .HasForeignKey(prod => prod.DiameterId);
            });

            builder.Entity<ProductInProject>(eb =>
            {
                eb.HasKey(pip => new { pip.ProjectId, pip.ProductId });

                eb.HasOne(pip => pip.Project)
                .WithMany(p => p.ProductsInProjects)
                .HasForeignKey(pip => pip.ProjectId);

                eb.HasOne(pip => pip.Product)
                .WithMany(prod => prod.ProductsInProjects)
                .HasForeignKey(pip => pip.ProductId);
            });

            builder.Entity<CompanyType>()
                .HasData(new CompanyType() { Id = 1, Name = "Biuro Projekotwe" },
                new CompanyType() { Id = 2, Name = "Wykonawca" },
                new CompanyType() { Id = 3, Name = "Zamawiający" },
                new CompanyType() { Id = 4, Name = "Dealer" },
                new CompanyType() { Id = 5, Name = "Inny" });

            builder.Entity<PersonRole>()
                .HasData(new PersonRole() { Id = 1, Name = "Przedstawiciel" },
                new PersonRole() { Id = 2, Name = "Handlowiec" },
                new PersonRole() { Id = 3, Name = "Projektant" },
                new PersonRole() { Id = 4, Name = "Asystent" },
                new PersonRole() { Id = 5, Name = "Kierownik" },
                new PersonRole() { Id = 6, Name = "Dyrektor" },
                new PersonRole() { Id = 7, Name = "Doradca" },
                new PersonRole() { Id = 8, Name = "Właściciel" },
                new PersonRole() { Id = 9, Name = "Inna" });

            builder.Entity<ProductDiameter>()
                .HasData(new ProductDiameter() { Id = 1, Diameter = "100" },
                new ProductDiameter() { Id = 2, Diameter = "150" },
                new ProductDiameter() { Id = 3, Diameter = "200" },
                new ProductDiameter() { Id = 4, Diameter = "250" },
                new ProductDiameter() { Id = 5, Diameter = "300" },
                new ProductDiameter() { Id = 6, Diameter = "400" },
                new ProductDiameter() { Id = 7, Diameter = "500" },
                new ProductDiameter() { Id = 8, Diameter = "600" },
                new ProductDiameter() { Id = 9, Diameter = "800" });

            builder.Entity<ProductUnit>()
                .HasData(new ProductUnit() { Id = 1, Unit = "M." },
                new ProductUnit() { Id = 2, Unit = "SZT." });

            builder.Entity<ProjectStatus>()
                .HasData(new ProjectStatus() { Id = 1, Name = "Nowy" },
                new ProjectStatus() { Id = 2, Name = "W opracowaniu" },
                new ProjectStatus() { Id = 3, Name = "Planowany" },
                new ProjectStatus() { Id = 4, Name = "Zapytanie" },
                new ProjectStatus() { Id = 5, Name = "Zgłoszony" },
                new ProjectStatus() { Id = 6, Name = "Zrealizowany" },
                new ProjectStatus() { Id = 7, Name = "Utracony" },
                new ProjectStatus() { Id = 8, Name = "Nie dotyczy" },
                new ProjectStatus() { Id = 9, Name = "Zdublowany" });

            builder.Entity<ProjectType>()
                .HasData(new ProjectType() { Id = 1, Name = "Projektuj" },
                new ProjectType() { Id = 2, Name = "Buduj" },
                new ProjectType() { Id = 3, Name = "Projektuj i buduj" });

            builder.Entity<Voivodeship>()
                .HasData(new Voivodeship() { Id = 1, Name = "Donośląskie" },
                new Voivodeship() { Id = 2, Name = "Kujawsko-Pomorskie" },
                new Voivodeship() { Id = 3, Name = "Lubelskie" },
                new Voivodeship() { Id = 4, Name = "Lubuskie" },
                new Voivodeship() { Id = 5, Name = "Łódzkie" },
                new Voivodeship() { Id = 6, Name = "Małopolskie" },
                new Voivodeship() { Id = 7, Name = "Mazowieckie" },
                new Voivodeship() { Id = 8, Name = "Opolskie" },
                new Voivodeship() { Id = 9, Name = "Podkarpackie" },
                new Voivodeship() { Id = 10, Name = "Podlaskie" },
                new Voivodeship() { Id = 11, Name = "Pomorskie" },
                new Voivodeship() { Id = 12, Name = "Śląskie" },
                new Voivodeship() { Id = 13, Name = "Świętokrzyskie" },
                new Voivodeship() { Id = 14, Name = "Warmińsko-Mazurskie" },
                new Voivodeship() { Id = 15, Name = "Wielkopolskie" },
                new Voivodeship() { Id = 16, Name = "Zachodniopomorskie" });
        }
    }
}
