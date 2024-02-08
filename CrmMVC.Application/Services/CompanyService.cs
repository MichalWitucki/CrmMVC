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

        public int AddCompany(CompanyVm companyVM)
        {
            var company = new Company() 
            {
                CompanyName = companyVM.Name,
                City = companyVM.City
            };
            _companyRepository.AddCompany(company);
            return 1;
        }

        public IEnumerable<CompanyVm> GetAll()
        {
            var companies = _companyRepository.GetAll();
            List<CompanyVm> companiesVm = new List<CompanyVm>();
            foreach (var company in companies)
            {
                var companyVm = new CompanyVm()
                {
                    Name = company.CompanyName,
                    Voivodeship = company.Voivodeship.VoivodeshipName,
                    City = company.City,
                    CompanyType = company.CompanyType.CompanyTypeName
                };
                companiesVm.Add(companyVm);
            }
            return companiesVm;
        }
    }
}
