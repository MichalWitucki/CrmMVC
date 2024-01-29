using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Domain.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string? TenderText { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public Voivodeship Voivodeship { get; set; }
        public int VoivodeshipId { get; set; }
        public string City { get; set; }
        public ProjectStatus Status { get; set; }
        public int StatusId { get; set; }
        public ProjectType Type { get; set; }
        public int TypeId { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public Company? Contractor { get; set; }
        public int? ContractorId { get; set; }
        public Company? IssuingAgency { get; set; }
        public int? IssuingAgencyId { get; set; }
        public Company? EngineeringOffice { get; set; }
        public int? EngineeringOfficeId { get; set; }
        public List<Product>? Products { get; set; } //= new List<Product>();
    }
}
