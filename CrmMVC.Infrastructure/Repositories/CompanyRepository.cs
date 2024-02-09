using CrmMVC.Domain.Model;
using CrmMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrmMVC.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CRMDbContext _context;

        public CompanyRepository(CRMDbContext context)
        {
            _context = context;
        }

        public IQueryable<Company> GetAll()
        {
            return _context.Companies
                .Include(c => c.Voivodeship)
                .Include(c => c.CompanyType);
        }

        public Company? GetCompany(int id) 
        {
            return _context.Companies
                .Include(c => c.Voivodeship)
                .Include(c => c.CompanyType)
                .FirstOrDefault(c => c.Id == id);
        }

        public int AddCompany(Company company) 
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return company.Id;
        }

        public IQueryable<Voivodeship> GetVoivodeships()
        {
            return _context.Voivodeships;
        }

        public IQueryable<CompanyType> GetCompanyTypes()
        {
            return _context.CompanyTypes;
        }
        
    }
}
