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
                    CompanyName = company.CompanyName,
                    Voivodeship = company.Voivodeship.VoivodeshipName,
                    City = company.City,
                    CompanyType = company.CompanyType.CompanyTypeName
                };
                companiesVm.Add(companyVm);
            }
            return companiesVm;
        }

		public ListCompanyVm GetAllForList(int pageSize, int pageNumber)
		{
			List<CompanyVm> companies = GetAll().ToList();
			List<CompanyVm> companiesToShow = companies.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
			ListCompanyVm companiesListVm = new ListCompanyVm()
			{
				Companies = companiesToShow,
				Count = companies.Count(),
				PageSize = pageSize,
				CurrentPage = pageNumber,
				Voivodeships = GetVoivodeships().ToList()
			};
			return companiesListVm;
		}

		public ListCompanyVm GetAllForList(int pageSize, int pageNumber, string CompanyNameSearchString, string voivodeshipSearchString)
        {
            List<CompanyVm> companies = GetAll()
                .Where(c => c.CompanyName.Contains(CompanyNameSearchString))
                .Where(c => c.Voivodeship == voivodeshipSearchString)
                .ToList();
			List<CompanyVm> companiesToShow = companies.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            ListCompanyVm companiesListVm = new ListCompanyVm()
            {
                Companies = companiesToShow,
                Count = companies.Count(),
                PageSize = pageSize,
                CurrentPage = pageNumber,
                CompanyNameSearchString = CompanyNameSearchString,
                Voivodeships = GetVoivodeships().ToList()
			};
            return companiesListVm;
        }

            public CompanyVm GetCompany(int id)
        {
            var company = _companyRepository.GetCompany(id);
            var companyVm = new CompanyVm()
            {
                Id = company.Id,
                CompanyName = company.CompanyName,
                Voivodeship = company.Voivodeship.VoivodeshipName,
                City = company.City,
                CompanyType = company.CompanyType.CompanyTypeName,
                ContactPeople = company.ContactPeople
            };
            return companyVm;
        }

        public AddCompanyVm GetCompanyForEdit(int id)
        {
            var company = _companyRepository.GetCompany(id);
            var companyVm = new AddCompanyVm()
            {
                Id = company.Id,
                CompanyName = company.CompanyName,
                VoivodeshipId = company.VoivodeshipId,
                City = company.City,
                CompanyTypeId = company.CompanyTypeId
            };
            return companyVm;
        }

        public void AddCompany(AddCompanyVm companyVm)
        {
            var company = new Company()
            {
                CompanyName = companyVm.CompanyName,
                City = companyVm.City,
                VoivodeshipId = companyVm.VoivodeshipId,
                CompanyTypeId = companyVm.CompanyTypeId
            };
            _companyRepository.AddCompany(company);
        }

        public void UpdateCompany(AddCompanyVm companyVm)
        {
            var company = new Company()
            {
                Id = companyVm.Id,
                CompanyName = companyVm.CompanyName,
                City = companyVm.City,
                VoivodeshipId = companyVm.VoivodeshipId,
                CompanyTypeId = companyVm.CompanyTypeId
            };
            _companyRepository.UpdateCompany(company);
        }

        public void DeleteCompany(int id)
        {
            _companyRepository.DeleteCompany(id);
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
