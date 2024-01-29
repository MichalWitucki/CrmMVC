using CrmMVC.Domain.Interfaces;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly Context _context;
        public ProjectRepository(Context context)
        {
            _context = context;
        }

        public int AddProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project.Id;
        }

        public void DeleteProject(int projectId)
        {
            Project? project = _context.Projects.Find(projectId);
            if (project != null)
            {
                _context.Projects.Remove(project);
                _context.SaveChanges();
            }
        }

        public IQueryable<Project>? GetAllProjects()
        {
            IQueryable<Project>? projects = _context.Projects;
            return projects;
        }

        public Project? GetProjectById(int projectId)
        {
            Project? project = _context.Projects.FirstOrDefault(p => p.Id == projectId);
            return project;
        }

        public IQueryable<ProductInProject>? GetProductsFromProject(int projectId)
        {
            IQueryable<ProductInProject>? productsInProject = _context.ProductsInProjects.Where(p => p.ProjectId == projectId);
            return productsInProject;
        }


        public IQueryable<Project>? GetProjectsByStatus(int statusId)
        {
            IQueryable<Project>? projectsWithStatus = _context.Projects.Where(p => p.StatusId == statusId);
            return projectsWithStatus;
        }

        public IQueryable<Project>? GetProjectsByType(int typeId)
        {
            IQueryable<Project>? projectsWithType = _context.Projects.Where(p => p.TypeId == typeId);
            return projectsWithType;
        }

        public IQueryable<Project>? GetProjectsByVoivodeship(int voivodeshipId)
        {
            IQueryable<Project>? projectsInVoivodeship = _context.Projects.Where(p => p.VoivodeshipId == voivodeshipId);
            return projectsInVoivodeship;
        }
    }
}
