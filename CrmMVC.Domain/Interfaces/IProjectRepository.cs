using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Domain.Interfaces
{
    public interface IProjectRepository
    {
		void Add(Project project);
		IQueryable<Project> GetAll();
        IQueryable<ProjectStatus> GetStatuses();
        IQueryable<ProjectType> GetTypes();
        IQueryable<Voivodeship> GetVoivodeships();
    }
}
