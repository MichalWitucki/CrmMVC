using CrmMVC.Application.ViewModels.Company;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<CompanyVm> GetAll();
        void AddCompany(AddCompanyVm company);
        IEnumerable<Voivodeship> GetVoivodeships();
        IEnumerable<CompanyType> GetCompanyTypes();
        CompanyVm GetCompany(int id);
        AddCompanyVm GetCompanyForEdit(int id);
        void UpdateCompany(AddCompanyVm companyVM);
        void DeleteCompany(int id);

        ListCompanyVm GetAllForList(int pageSize, int pageNumber);
		ListCompanyVm GetAllForList(int pageSize, int pageNumber, string CompanyNameSearchString, string VoivodeshipSearchString);
	}
}
