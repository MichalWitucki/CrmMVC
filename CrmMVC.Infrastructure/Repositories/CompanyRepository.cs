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
                .Include(c => c.Type);
        }

        public Company? Get(int id) 
        {
            return _context.Companies
                .Include(c => c.Voivodeship)
                .Include(c => c.Type)
                .Include(c => c.ContactPeople)
                .FirstOrDefault(c => c.Id == id);
        }

        public void Add(Company company) 
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void Update(Company company)
        {
            _context.Attach(company);
            _context.Entry(company).Property("CompanyName").IsModified = true;
            _context.Entry(company).Property("VoivodeshipId").IsModified = true;
            _context.Entry(company).Property("City").IsModified = true;
            _context.Entry(company).Property("CompanyTypeId").IsModified = true;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Company? company = _context.Companies.Find(id);
            
            _context.Companies.Remove(company);
            _context.SaveChanges();
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
