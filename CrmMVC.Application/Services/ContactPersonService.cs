using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.ContactPerson;
using CrmMVC.Domain.Interfaces;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.Services
{
    public class ContactPersonService : IContactPersonService
    {
        private readonly IContactPersonRepository _contactPersonRepository;

        public ContactPersonService(IContactPersonRepository contactPersonRepository)
        {
            _contactPersonRepository = contactPersonRepository;
        }

        public IEnumerable<ContactPersonVm> GetAll()
        {
            IQueryable<ContactPerson> contactPeople = _contactPersonRepository.GetAll();
            List<ContactPersonVm> contactPeopleVm = new List<ContactPersonVm>();
            foreach (var person in contactPeople)
            {
                ContactPersonVm contactPersonVm = new ContactPersonVm()
                {
                    Id = person.Id,
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    Email = person.Email,
                    PhoneNumber = person.PhoneNumber,
                    Role = person.Role.PersonRoleName,
                    Company = person.Company.CompanyName
                };

                contactPeopleVm.Add(contactPersonVm);
            }
            return contactPeopleVm;
        }
    }
}
