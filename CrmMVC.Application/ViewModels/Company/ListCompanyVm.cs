using CrmMVC.Application.ViewModels.Common;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class ListCompanyVm : NavigationVm
    {
        public List<CompanyVm> Companies { get; set; }
        public string CompanyNameSearchString { get; set; }
        public string VoivodeshipSearchString { get; set; }
        public string CitySearchString { get; set; }
        public string CompanyTypeSearchString { get; set; }
		public List<Voivodeship> Voivodeships { get; set; }
        public List<CompanyType> CompanyTypes { get; set; }
    }
}
