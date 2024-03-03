﻿using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.Project;
using CrmMVC.Domain.Interfaces;
using CrmMVC.Domain.Model;
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
            IQueryable<Project> projects = _projectRepository.GetAll();
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
                Projects = projects,
                Voivodeships = GetVoivodeships().ToList(),
                Statuses = GetStatuses().ToList(),
                Types = GetTypes().ToList()
            };
            return projectsListVm;
        }

        public IEnumerable<Voivodeship> GetVoivodeships()
        {
            return _projectRepository.GetVoivodeships().ToList();
        }

        public IEnumerable<ProjectStatus> GetStatuses()
        {
            return _projectRepository.GetStatuses().ToList();
        }

        public IEnumerable<ProjectType> GetTypes()
        {
            return _projectRepository.GetTypes().ToList();
        }

		public void AddProject(AddProjectVm projectVm)
		{
            Project project = new Project()
            {
                TenderText = projectVm.TenderText,
                FullName = projectVm.FullName,
                ShortName = projectVm.ShortName,
                VoivodeshipId = projectVm.VoivodeshipId,
                StatusId = projectVm.StatusId,
                TypeId = projectVm.TypeId,
                StartDate = projectVm.StartDate,
                EndDate = projectVm.EndDate,
                City = projectVm.City
            };
            _projectRepository.Add(project);
		}
	}
}
