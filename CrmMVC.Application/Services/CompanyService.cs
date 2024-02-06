using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper) 
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public int AddCompany(NewCompanyVM companyVM)
        {
            Company company = _mapper.Map<Company>(companyVM);
            _companyRepository.AddCompany(company);
            return company.Id;
        }

        public List<Company> GetAllCompaniesForList()
        {
            var companies = _companyRepository.GetAllCompanies().ToList();
            return companies;
        }

        public CompanyDetailsVM GetCompanyDetails(int companyId)
        {
            var company = _companyRepository.GetCompany(companyId);
            var companyVM = _mapper.Map<CompanyDetailsVM>(company);


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
