using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Domain.Model
{
    public class Company
    {
        public int Id { get; set; }
        public Voivodeship Voivodeship { get; set; }
        public int VoivodeshipId { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public CompanyType Type { get; set; }
        public int TypeId { get; set; }
        public List<ContactPerson>? ContactPeople { get; set; } = new List<ContactPerson>();
        public List<Project>? Contractors { get; set; } = new List<Project>();
        public List<Project>? IssuingAgencies { get; set; } = new List<Project>();
        public List<Project>? EngineeringOfices { get; set; } = new List<Project>();
    }

}
