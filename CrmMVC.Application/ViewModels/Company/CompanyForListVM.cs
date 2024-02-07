﻿
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
    public class CompanyForListVm : IMapFrom<Domain.Model.Company>
    {
        public int Id { get; set; }
        public Voivodeship Voivodeship{ get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public CompanyType Type { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Model.Company, CompanyForListVm>();
        }
    }
}
