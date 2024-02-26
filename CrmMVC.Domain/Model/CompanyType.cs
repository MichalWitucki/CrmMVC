using System.Collections.Generic;

namespace CrmMVC.Domain.Model
{
    public class CompanyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Company>? Companies { get; set; }
    }
}