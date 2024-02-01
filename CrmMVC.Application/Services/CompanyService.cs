using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.Company;
using CrmMVC.Domain.Interfaces;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository) 
        {
            _companyRepository = companyRepository;
        }

        public int AddCompany(NewCompanyVM company)
        {
            throw new NotImplementedException();
        }

        public ListCompanyForListVM GetAllCompaniesForList()
        {
            IQueryable<Company>? companies = _companyRepository.GetAllCompanies();
            ListCompanyForListVM result = new ListCompanyForListVM();
            result.Companies = new List<CompanyForListVM>();
            foreach (var company in companies)
            {
                CompanyForListVM companyVM = new CompanyForListVM()
                {
                    Id = company.Id,
                    Voivodeship = company.Voivodeship,
                    City = company.City,
                    Name = company.Name,
                    Type = company.Type
                };
                result.Companies.Add(companyVM);
            }
            result.Count = result.Companies.Count;
            return result;
        }

        public CompanyDetailsVM GetCompanyDetails(int companyId)
        {
            Company? company = _companyRepository.GetCompany(companyId);
            CompanyDetailsVM companyVM = new CompanyDetailsVM();
            companyVM.Id = company.Id;
            companyVM.Voivodeship = company.Voivodeship;
            companyVM.City = company.City;
            companyVM.Name = company.Name;
            companyVM.Type = company.Type;
            companyVM.ContactPeople = new List<ContactPeopleForListVM>();
            foreach (var contactPerson in company.ContactPeople)
            {
                ContactPeopleForListVM contactPeopleVM = new ContactPeopleForListVM()
                {
                    Id= contactPerson.Id,
                    FirstName = contactPerson.FirstName,
                    LastName = contactPerson.LastName,
                    PhoneNumber = contactPerson.PhoneNumber,
                    Email = contactPerson.Email,
                    Role = contactPerson.Role
                };
                companyVM.ContactPeople.Add(contactPeopleVM);
            }
            return companyVM;
        }
    }
}
