using CrmMVC.Domain.Interfaces;
using CrmMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IContactPersonRepository, ContactPersonRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            return services;
        }
    }
}

