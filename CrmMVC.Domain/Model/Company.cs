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
        public CompanyType CompanyType { get; set; }
        public int CompanyTypeId { get; set; }
        public List<ContactPerson> ContactPersons { get; set; } = new List<ContactPerson>();
    }

}
