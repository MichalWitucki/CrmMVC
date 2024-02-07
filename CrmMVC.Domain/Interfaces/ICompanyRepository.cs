using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        int AddCompany(Company company);
        void DeleteCompany(int companyId);
        IQueryable<Company>? GetAll();
        IQueryable<Company>? GetCompaniesByCompanyType(int typeId);
        Company? GetCompany(int companyId);
        IQueryable<ContactPerson>? GetPeopleFromCompany(int companyId);
    }
}
