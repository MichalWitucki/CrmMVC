using CrmMVC.Application.Interfaces;
using CrmMVC.Application.Services;
using CrmMVC.Application.ViewModels.Company;
using CrmMVC.Application.ViewModels.ContactPerson;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			services.AddTransient<ICompanyService, CompanyService>();
			services.AddTransient<IContactPersonService, ContactPersonService>();
			services.AddTransient<IProjectService, ProjectService>();

			services.AddValidatorsFromAssemblyContaining<AddCompanyVmValidator>()
				.AddFluentValidationAutoValidation()
				.AddFluentValidationClientsideAdapters();
			return services;
		}
	}
}
