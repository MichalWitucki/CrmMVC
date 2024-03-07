using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmMVC.Domain.Interfaces;
using CrmMVC.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CrmMVC.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly CRMDbContext _context;

        public ProjectRepository(CRMDbContext context)
        {
            _context = context;
        }

        public IQueryable<Project> GetAll()
        {
            return _context.Projects
                .Include(p => p.Status)
                .Include(p => p.Voivodeship)
                .Include(p => p.Type);
        }

        public IQueryable<ProjectStatus> GetStatuses()
        {
            return _context.ProjectStatuses;
        }

        public IQueryable<Voivodeship> GetVoivodeships()
        {
            return _context.Voivodeships;
        }

        public IQueryable<ProjectType> GetTypes()
        {
            return _context.ProjectTypes;
        }

		public void Add(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

		public Project? Get(int id)
		{
			return _context.Projects
				.Include(p => p.Status)
				.Include(p => p.Voivodeship)
				.Include(p => p.Type)
                .Where(p => p.Id == id).FirstOrDefault();
		}
	}
}
