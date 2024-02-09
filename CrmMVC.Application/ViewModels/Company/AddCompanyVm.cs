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
        public string? Name { get; set; }
        public int VoivodeshipId { get; set; }
        public List<Voivodeship> Voivodeships { get; set; }
        public string? City { get; set; }
        public int CompanyTypeId { get; set; }
        public List<CompanyType> CompanyTypes { get; set; }
    }
}
