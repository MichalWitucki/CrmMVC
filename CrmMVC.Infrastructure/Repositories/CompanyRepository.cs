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

        public int AddCompany(Company company) 
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return company.Id;
        }

        //public void DeleteCompany(int companyId) 
        //{
        //    Company? companyToDelete = _context.Companies.Find(companyId);
        //    if (companyToDelete != null)
        //    {
        //        _context.Companies.Remove(companyToDelete);
        //        _context.SaveChanges();
        //    }
        //}

        public IQueryable<Company> GetAll()
        {
            return _context.Companies
                .Include(c => c.Voivodeship)
                .Include(c => c.CompanyType);
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
