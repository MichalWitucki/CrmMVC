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
        int AddCompany(AddCompanyVm company);
        IEnumerable<Voivodeship> GetVoivodeships();
        IEnumerable<CompanyType> GetCompanyTypes();
        CompanyVm GetCompany(int id);
    }
}
