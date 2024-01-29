namespace CrmMVC.Domain.Model
{
    public class CompanyType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Company>? Companies { get; set; } = new List<Company>();
    }
}