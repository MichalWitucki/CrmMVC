using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class ListCompanyVm
    {
        public List<CompanyVm> Companies { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string CompanyNameSearchString { get; set; }
        public string VoivodeshipSearchString { get; set; }
        public string CitySearchString { get; set; }
        public string CompanyTypeSearchString { get; set; }
		public List<Voivodeship> Voivodeships { get; set; }
		public int Count { get; set; }
    }
}
