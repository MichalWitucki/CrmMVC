using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class CompanyVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Voivodeship { get; set; }
        public string City { get; set; }
        public string CompanyType { get; set; }
    }
}
