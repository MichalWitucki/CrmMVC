namespace CrmMVC.Domain.Model
{
    public class ContactPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}