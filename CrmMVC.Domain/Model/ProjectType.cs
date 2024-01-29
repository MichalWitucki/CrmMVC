namespace CrmMVC.Domain.Model
{
    public class ProjectType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Project>? Projects { get; set; } = new List<Project>();
    }
}