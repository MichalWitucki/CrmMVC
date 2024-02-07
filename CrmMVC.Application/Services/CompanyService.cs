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

        public int AddCompany(CompanyVm companyVM)
        {
            Company company = _mapper.Map<Company>(companyVM);
            _companyRepository.AddCompany(company);
            return company.Id;
        }

        public IEnumerable<CompanyVm> GetAll()
        {
            var companies = _companyRepository.GetAll();
            IEnumerable<CompanyVm> companyVms = _mapper.Map<IEnumerable<CompanyVm>>(companies);
            return companyVms;
        }

        public CompanyDetailsVm GetCompanyDetails(int companyId)
        {
            var company = _companyRepository.GetCompany(companyId);
            var companyVM = _mapper.Map<CompanyDetailsVm>(company);


            companyVM.ContactPeople = new List<ContactPeopleForListVm>();
            foreach (var contactPerson in company.ContactPeople)
            {
                ContactPeopleForListVm contactPeopleVM = new ContactPeopleForListVm()
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
