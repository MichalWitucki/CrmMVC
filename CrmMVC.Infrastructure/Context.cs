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
        public DbSet<ContactPerson> ContactPersons { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>(eb =>
            {
                eb.HasOne(c => c.Voivodeship)
                .WithMany(v => v.Companies)
                .HasForeignKey(c => c.VoivodeshipId);

                eb.HasOne(c => c.CompanyType)
                .WithMany(ct => ct.Companies)
                .HasForeignKey(c => c.CompanyTypeId);

                eb.HasMany(c => c.ContactPersons)
                .WithOne(p => p.Company)
                .HasForeignKey(p => p.CompanyId);
            });
               
        }
    }
}
