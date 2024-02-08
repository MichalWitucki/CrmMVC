using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class AddCompanyVm
    {
        public string Name { get; set; } = default!;
        public List<Voivodeship> Voivodeship { get; set; }
        public string City { get; set; }
        public List<CompanyType> companyType { get; set; }
    }
}
