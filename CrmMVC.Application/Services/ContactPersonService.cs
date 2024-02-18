using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.Company;
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

        public void AddContactPerson(AddContactPersonVm personVm)
        {
            var person = new ContactPerson()
            {
                FirstName = personVm.FirstName,
                LastName = personVm.LastName,
                Email = personVm.Email,
                PhoneNumber = personVm.PhoneNumber,
                RoleId = personVm.RoleId,
                CompanyId = personVm.CompanyId
            };
            _contactPersonRepository.AddContactPerson(person);
        }

        public void DeleteContactPerson(int id)
        {
            _contactPersonRepository.Delete(id);
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

        public ContactPersonVm GetContactPerson(int id)
        {
            var contactPerson = _contactPersonRepository.GetContactPerson(id);
            var contactPersonVm = new ContactPersonVm()
            {
                Id = contactPerson.Id,
                FirstName = contactPerson.FirstName,
                LastName = contactPerson.LastName,
                Email = contactPerson.Email,
                PhoneNumber = contactPerson.PhoneNumber,
                Role = contactPerson.Role.PersonRoleName,
                Company = contactPerson.Company.CompanyName,
                CompanyId = contactPerson.CompanyId                
            };
            return contactPersonVm;
        }


        public AddContactPersonVm GetContactPersonForEdit(int id)
        {
            var contactPerson = _contactPersonRepository.GetContactPerson(id);
            var contactPersonVm = new AddContactPersonVm()
            {
                Id = contactPerson.Id,
                FirstName = contactPerson.FirstName,
                LastName = contactPerson.LastName,
                Email = contactPerson.Email,
                PhoneNumber = contactPerson.PhoneNumber,
                RoleId = contactPerson.RoleId,
                CompanyId = contactPerson.CompanyId,
                Roles = GetPersonRoles().ToList()
        };
            return contactPersonVm;
        }

        public IEnumerable<PersonRole> GetPersonRoles()
        {
            return _contactPersonRepository.GetPersonRoles().ToList();
        }

        public void EditContactPerson(AddContactPersonVm personVm)
        {
            var contactPerson = new ContactPerson()
            {
                Id = personVm.Id,
                FirstName = personVm.FirstName,
                LastName= personVm.LastName,
                Email = personVm.Email,
                PhoneNumber = personVm.PhoneNumber,
                RoleId = personVm.RoleId,
            };
            _contactPersonRepository.UpdateContactPerson(contactPerson);
        }
    }
}
