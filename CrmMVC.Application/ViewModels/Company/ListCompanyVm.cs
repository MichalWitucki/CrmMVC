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
        public int Count { get; set; }
    }
}
