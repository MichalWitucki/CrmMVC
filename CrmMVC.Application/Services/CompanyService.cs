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

        public IEnumerable<CompanyVm> GetAll()
        {
            var companies = _companyRepository.GetAll();
            List<CompanyVm> companiesVm = new List<CompanyVm>();
            foreach (var company in companies)
            {
                var companyVm = new CompanyVm()
                {
                    Id = company.Id,
                    CompanyName = company.Name,
                    Voivodeship = company.Voivodeship.Name,
                    City = company.City,
                    CompanyType = company.Type.Name
                };
                companiesVm.Add(companyVm);
            }
            return companiesVm;
        }


		public ListCompanyVm GetAllForList(int pageSize, int pageNumber, string CompanyNameSearchString, string voivodeshipSearchString, string citySearchString, string companyTypeSearchString)
        {
            List<CompanyVm> companies = GetAll()
                .Where(c => c.CompanyName.ToLower().Contains(CompanyNameSearchString.ToLower()))
                .Where(c => c.City.ToLower().Contains(citySearchString.ToLower()))
				.ToList();

			companies = !string.IsNullOrEmpty(voivodeshipSearchString) ? companies
                .Where(c => c.Voivodeship == voivodeshipSearchString).ToList() : companies;
			companies = !string.IsNullOrEmpty(companyTypeSearchString) ? companies
                .Where(c => c.CompanyType == companyTypeSearchString).ToList() : companies;

			List<CompanyVm> companiesToShow = companies.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            ListCompanyVm companiesListVm = new ListCompanyVm()
            {
                Companies = companiesToShow,
                Count = companies.Count(),
                PageSize = pageSize,
                CurrentPage = pageNumber,
                CompanyNameSearchString = CompanyNameSearchString,
                Voivodeships = GetVoivodeships().ToList(),
                CompanyTypes = GetCompanyTypes().ToList()
			};
            return companiesListVm;
        }

            public CompanyVm GetCompany(int id)
        {
            var company = _companyRepository.Get(id);
            var companyVm = new CompanyVm()
            {
                Id = company.Id,
                CompanyName = company.Name,
                Voivodeship = company.Voivodeship.Name,
                City = company.City,
                CompanyType = company.Type.Name,
                ContactPeople = company.ContactPeople
            };
            return companyVm;
        }

        public AddCompanyVm GetCompanyForEdit(int id)
        {
            var company = _companyRepository.Get(id);
            var companyVm = new AddCompanyVm()
            {
                Id = company.Id,
                CompanyName = company.Name,
                VoivodeshipId = company.VoivodeshipId,
                City = company.City,
                CompanyTypeId = company.TypeId
            };
            return companyVm;
        }

        public void AddCompany(AddCompanyVm companyVm)
        {
            var company = new Company()
            {
                Name = companyVm.CompanyName,
                City = companyVm.City,
                VoivodeshipId = companyVm.VoivodeshipId,
                TypeId = companyVm.CompanyTypeId
            };
            _companyRepository.Add(company);
        }

        public void UpdateCompany(AddCompanyVm companyVm)
        {
            var company = new Company()
            {
                Id = companyVm.Id,
                Name = companyVm.CompanyName,
                City = companyVm.City,
                VoivodeshipId = companyVm.VoivodeshipId,
                TypeId = companyVm.CompanyTypeId
            };
            _companyRepository.Update(company);
        }

        public void DeleteCompany(int id)
        {
            _companyRepository.Delete(id);
        }

        public IEnumerable<Voivodeship> GetVoivodeships()
        {
            return _companyRepository.GetVoivodeships().ToList();
        }

        public IEnumerable<CompanyType> GetCompanyTypes()
        {
            return _companyRepository.GetCompanyTypes().ToList();
        }
    }
}
