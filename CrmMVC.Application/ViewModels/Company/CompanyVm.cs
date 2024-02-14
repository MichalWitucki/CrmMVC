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
        public string Voivodeship { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }

        public List<CrmMVC.Domain.Model.ContactPerson>? ContactPeople { get; set; } = new List<Domain.Model.ContactPerson>();
    }
}
