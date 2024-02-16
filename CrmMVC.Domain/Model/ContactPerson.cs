namespace CrmMVC.Domain.Model
{
    public class ContactPerson
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }    
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public PersonRole Role { get; set; }
        public int RoleId { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}