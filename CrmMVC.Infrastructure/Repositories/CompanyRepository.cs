using CrmMVC.Domain.Model;
using CrmMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly Context _context;

        public CompanyRepository(Context context)
        {
            _context = context;
        }

        public int AddCompany(Company company) 
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return company.Id;
        }

        public void DeleteCompany(int companyId) 
        {
            Company? companyToDelete = _context.Companies.Find(companyId);
            if (companyToDelete != null)
            {
                _context.Companies.Remove(companyToDelete);
                _context.SaveChanges();
            }
        }

        public IQueryable<Company> GetAllCompanies()
        {
            IQueryable<Company> companies = _context.Companies;
            return companies;
        }

        public Company? GetCompany(int companyId)
        {
            Company? company = _context.Companies.FirstOrDefault(c => c.Id == companyId);
            return company;
        }

        public IQueryable<Company> GetCompaniesByCompanyType(int typeId)
        {
            IQueryable<Company> companiesWithType = _context.Companies.Where(c => c.TypeId == typeId);
            return companiesWithType;
        }

        public IQueryable<ContactPerson> GetPeopleFromCompany(int companyId)
        {
            Company? company = _context.Companies.FirstOrDefault(c => c.Id == companyId);
            if(company != null)
            {
                IQueryable<ContactPerson> contactPeople = _context.ContactPeople.Where(c => c.CompanyId == companyId);
                return contactPeople;
            }
            return null;
        }
    }
}
