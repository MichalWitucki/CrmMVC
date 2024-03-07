using CrmMVC.Application.ViewModels.Project;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.Interfaces
{
    public interface IProjectService
    {
		void AddProject(AddProjectVm project);
		IEnumerable<ProjectVm> GetAll();
        ListProjectVm GetAllForList(int pageSize, int pageNumber, string fullNameSearchString, string shortNameSearchString, string voivodeshipSearchString, string citySearchString, string typeSearchString, string statusSearchString);
		ProjectDetailsVm GetProject(int id);
		IEnumerable<ProjectStatus> GetStatuses();
        IEnumerable<ProjectType> GetTypes();
        IEnumerable<Voivodeship> GetVoivodeships();
    }
}
