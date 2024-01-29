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
        int AddProject(Project project);
        void DeleteProject(int projectId);
        IQueryable<Project>? GetAllProjects();
        Project? GetProjectById(int projectId);
        IQueryable<Project>? GetProjectsByStatus(int statusId);
        IQueryable<Project>? GetProjectsByVoivodeship(int voivodeshipId);
        IQueryable<Project>? GetProjectsByType(int typeId);
        IQueryable<Product>? GetProductsFromProject(int projectId);

    }
}
