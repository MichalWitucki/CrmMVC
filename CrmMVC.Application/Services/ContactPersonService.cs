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
					Role = person.Role.Name,
					Company = person.Company.Name
				};

				contactPeopleVm.Add(contactPersonVm);
			}
			return contactPeopleVm;
		}

		public ListContactPersonVm GetAllForList(int pageSize, int pageNumber,
			string firstNameSearchString, string lastNameSearchString, string emailSearchString,
			string phoneNumberSearchString, string roleSearchString, string companySearchString)
		{
			List<ContactPersonVm> contactPeople = GetAll().ToList()
				.Where(cp => cp.FirstName.ToLower().Contains(firstNameSearchString.ToLower()))
				.Where(cp => cp.LastName.ToLower().Contains(lastNameSearchString.ToLower()))
				.Where(cp => cp.Email.ToLower().Contains(emailSearchString.ToLower()))
				.Where(cp => cp.PhoneNumber.ToLower().Contains(phoneNumberSearchString.ToLower()))
				//company
				.ToList();

			contactPeople = !string.IsNullOrEmpty(roleSearchString) ? contactPeople.Where(cp => cp.Role == roleSearchString).ToList() : contactPeople;

			List<ContactPersonVm> contactPeopleToShow = contactPeople.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

			ListContactPersonVm contactPeopleListVm = new ListContactPersonVm()
			{
				ContactPeople = contactPeopleToShow,
				Count = contactPeople.Count(),
				PageSize = pageSize,
				CurrentPage = pageNumber,
				FirstNameSearchString = firstNameSearchString,
				LastNameSearchString = lastNameSearchString,
				EmailSearchString = emailSearchString,
				PhoneNumberSearchString = phoneNumberSearchString,
				Roles = GetPersonRoles().ToList(),
				//company
			};
			return contactPeopleListVm;
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
		_contactPersonRepository.Add(person);
	}

	public void DeleteContactPerson(int id)
	{
		_contactPersonRepository.Delete(id);
	}




	public ContactPersonVm GetContactPerson(int id)
	{
		var contactPerson = _contactPersonRepository.Get(id);
		var contactPersonVm = new ContactPersonVm()
		{
			Id = contactPerson.Id,
			FirstName = contactPerson.FirstName,
			LastName = contactPerson.LastName,
			Email = contactPerson.Email,
			PhoneNumber = contactPerson.PhoneNumber,
			Role = contactPerson.Role.Name,
			Company = contactPerson.Company.Name,
			CompanyId = contactPerson.CompanyId
		};
		return contactPersonVm;
	}


	public AddContactPersonVm GetContactPersonForEdit(int id)
	{
		var contactPerson = _contactPersonRepository.Get(id);
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
			LastName = personVm.LastName,
			Email = personVm.Email,
			PhoneNumber = personVm.PhoneNumber,
			RoleId = personVm.RoleId,
		};
		_contactPersonRepository.Update(contactPerson);
	}
}
}
