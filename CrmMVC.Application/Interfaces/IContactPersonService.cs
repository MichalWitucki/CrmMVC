﻿using CrmMVC.Application.ViewModels.ContactPerson;
using CrmMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.Interfaces
{
    public interface IContactPersonService
    {
        void AddContactPerson(AddContactPersonVm person);
        void DeleteContactPerson(int id);
        IEnumerable<ContactPersonVm> GetAll();
        ContactPersonVm GetContactPerson(int id);
        IEnumerable<PersonRole> GetPersonRoles();
        void EditContactPerson(AddContactPersonVm personVm);
        AddContactPersonVm GetContactPersonForEdit(int id);
		ListContactPersonVm GetAllForList(int pageSize, int pageNumber, string firstNameSearchString, string lastNameSearchString, string emailSearchString, string phoneNumberSearchString, string roleSearchString, string companySearchString);
	}
}
