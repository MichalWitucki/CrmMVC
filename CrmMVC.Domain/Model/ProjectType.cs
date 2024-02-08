using System.Collections.Generic;

namespace CrmMVC.Domain.Model
{
    public class ProjectType
    {
        public int Id { get; set; }
        public string ProjectTypeName { get; set; }
        public List<Project>? Projects { get; set; } = new List<Project>();
    }
}