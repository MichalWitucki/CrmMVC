using System.Collections.Generic;

namespace CrmMVC.Domain.Model
{
    public class PersonRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ContactPerson>? ContactPeople { get; set; }
    }
}