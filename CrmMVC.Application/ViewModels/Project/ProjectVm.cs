using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Project
{
	public class ProjectVm
	{
		public int Id { get; set; }
		public string City { get; set; }
		public string ShortName { get; set; }
		public string FullName { get; set; }
		public string Voivodeship { get; set; }
		public string Status { get; set; }
		public string Type { get; set; }
		public DateOnly? StartDate { get; set; }
		public DateOnly? EndDate { get; set; }
	}
}
