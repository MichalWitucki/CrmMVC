using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Project
{
	public class AddProjectVm
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public string ShortName { get; set; }
		public string City { get; set; }
		public string? TenderText { get; set; }
		public int VoivodeshipId { get; set; }
		public List<Voivodeship> Voivodeships { get; set; }
		public int StatusId { get; set; }
		public List<ProjectStatus> Statuses { get; set; }
		public int TypeId { get; set; }
		public List<ProjectType> Types { get; set; }
		public DateOnly? StartDate { get; set; }
		public DateOnly? EndDate { get; set; }
	}
}
