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
        //public int VoivodeshipId { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        //public int CompanyTypeId { get; set; }
        public List<ContactPerson>? ContactPeople { get; set; } = new List<ContactPerson>();
    }
}
