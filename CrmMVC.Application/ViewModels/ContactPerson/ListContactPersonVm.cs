using CrmMVC.Application.ViewModels.Common;
using CrmMVC.Application.ViewModels.Company;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.ContactPerson
{
	public class ListContactPersonVm : NavigationVm
	{
        public int Id { get; set; }
        public List<ContactPersonVm> ContactPeople { get; set; }
		public string FirstNameSearchString { get; set; }
		public string LastNameSearchString { get; set; }
		public string EmailSearchString { get; set; }
		public string PhoneNumberSearchString { get; set; }
		public string RoleSearchString { get; set; }
		public string CompanyNameSearchString { get; set; }
		public List<PersonRole> Roles { get; set; }
		public List<Domain.Model.Company> Companies { get; set; }
	}
}
