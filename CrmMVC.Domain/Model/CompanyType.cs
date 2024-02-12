using System.Collections.Generic;

namespace CrmMVC.Domain.Model
{
    public class CompanyType
    {
        public int Id { get; set; }
        public string CompanyTypeName { get; set; }
        public List<Company>? Companies { get; set; }
    }
}