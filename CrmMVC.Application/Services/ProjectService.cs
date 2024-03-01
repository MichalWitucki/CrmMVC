using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.Project;
using CrmMVC.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CrmMVC.Application.Services
{
	public class ProjectService : IProjectService
	{
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;

        }

        public IEnumerable<ProjectVm> GetAll()
        {
            List<Project> projects = _projectRepository.GetAll();
            List<ProjectVm> projectsVm = new List<ProjectVm>();
            foreach (var project in projects)
            {
                ProjectVm projectVm = new ProjectVm()
                {
                    Id = project.Id,
                    City = project.City,
                    ShortName = project.ShortName,
                    FullName = project.FullName,
                    Voivodeship = project.Voivodeship.Name,
                    Status = project.Status.Name,
                    Type = project.Type.Name,
                    StartDate = project.StartDate,
                    EndDate = project.EndDate,
                };
                projectsVm.Add(projectVm);
            }
            return projectsVm;
        }

        public ListProjectVm GetAllForList(int pageSize, int pageNumber, string CompanyNameSearchString, string voivodeshipSearchString, string citySearchString, string companyTypeSearchString)
        {
            List<ProjectVm> projects = GetAll().ToList();

            //List<ProjectVm> projectsToShow
            
            ListProjectVm projectsListVm = new ListProjectVm()
            {

            };


        }


    }
}
