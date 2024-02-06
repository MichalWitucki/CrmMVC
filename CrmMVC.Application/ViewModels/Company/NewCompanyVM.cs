
using AutoMapper;
using CrmMVC.Application.Mapping;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class NewCompanyVM : IMapFrom<Domain.Model.Company>
    {
        public string Name { get; set; } = default!;
        public Voivodeship Voivodeship { get; set; }
        public string City { get; set; }
        public CompanyType companyType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Model.Company, NewCompanyVM>();
        }
    }
}
