
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class ListCompanyForListVm
    {
        public List<CompanyForListVm> Companies { get; set; }
        public int Count { get; set; }
    }
}
