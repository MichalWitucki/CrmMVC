using System.Collections.Generic;

namespace CrmMVC.Domain.Model
{
    public class Voivodeship
    {
        public int Id { get; set; }
        public string VoivodeshipName { get; set; }
        public List<Company>? Companies { get; set; }
        public List<Project>? Projects { get; set; }
    }
}