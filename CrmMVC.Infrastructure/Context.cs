using CrmMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
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
                .HasData(new CompanyType() { Id = 1, Type = "Biuro Projekotwe" },
                new CompanyType() { Id = 2, Type = "Wykonawca" },
                new CompanyType() { Id = 3, Type = "Zamawiający" },
                new CompanyType() { Id = 4, Type = "Dealer" },
                new CompanyType() { Id = 5, Type = "Inny" });
        }
    }
}
