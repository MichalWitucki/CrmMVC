using CrmMVC.Application.ViewModels.Common;
using CrmMVC.Application.ViewModels.Company;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Project
{
	public class ListProjectVm : NavigationVm
	{
		public List<ProjectVm> Projects { get; set; }
		public List<Voivodeship> Voivodeships { get; set; }
		public List<ProjectStatus> Statuses { get; set; }
		public List<ProjectType> Types { get; set; }
		public string ShortNameSearchString { get; set; }
		public string FullNameSearchString { get; set; }
		public string CitySearchString { get; set; }
		public string VoivodeshipSearchString { get; set; }
		public string StatusSearchString { get; set; }
		public string TypeSearchString { get; set; }
		public DateOnly StardDateSearchBy { get; set; }
	}
}
