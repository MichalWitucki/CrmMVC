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
        void Add(Company company);
        IQueryable<Company>? GetAll();
        IQueryable<Voivodeship> GetVoivodeships();
        IQueryable<CompanyType> GetCompanyTypes();
        Company? Get(int id);
        void Update(Company company);
        void Delete(int id);
    }
}
