using AutoMapper;
using AutoMapper.QueryableExtensions;
using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.CompanyVMs;
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
            var companies = _companyRepository.GetAllCompanies().ProjectTo<CompanyForListVM>(_mapper.ConfigurationProvider).ToList();
            var companyList = new ListCompanyForListVM()
            {
                Companies = companies,
                Count = companies.Count()
            };
            return companyList;
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
