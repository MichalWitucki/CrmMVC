using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class ListCompanyForListVM
    {
        public List<CompanyForListVM> Companies { get; set; }
        public int Count { get; set; }
    }
}
