
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Company
{
    public class CompanyDetailsVM //: IMapFrom<Domain.Model.Company>
    {
        public int Id { get; set; }
        public Voivodeship Voivodeship { get; set; }
        public int VoivodeshipId { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public CompanyType Type { get; set; }
        public List<ContactPeopleForListVM>? ContactPeople { get; set; }

        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<Domain.Model.Company, CompanyForListVM>();
        //    //.forMember(s => s.CityName, opt =>opt.MapFrom(d => d.City + " " d.Name));
        //}
    }
}
