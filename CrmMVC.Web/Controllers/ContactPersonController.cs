﻿using Microsoft.AspNetCore.Mvc;
using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.Company;
using System.Collections.Generic;
using CrmMVC.Application.Services;
using CrmMVC.Application.ViewModels.ContactPerson;
using System.Linq;
using System;

namespace CrmMVC.Web.Controllers
{
    public class ContactPersonController : Controller
    {
        private readonly IContactPersonService _contactPersonService;

        public ContactPersonController(IContactPersonService contactPersonService)
        {
            _contactPersonService = contactPersonService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contactPeople = _contactPersonService.GetAllForList(10,1,"","","","","","");
            return View(contactPeople);
        }

		[HttpPost]
		public IActionResult Index(int pageSize, int? pageNumber,
			string firstNameSearchString, string lastNameSearchString, string emailSearchString,
			string phoneNumberSearchString, string roleSearchString, string companySearchString)
		{
			if (!pageNumber.HasValue)
			{
				pageNumber = 1;
			}
			firstNameSearchString = firstNameSearchString is null ? String.Empty : firstNameSearchString;
			lastNameSearchString = lastNameSearchString is null ? String.Empty : lastNameSearchString;
			emailSearchString = emailSearchString is null ? String.Empty : emailSearchString;
			phoneNumberSearchString = phoneNumberSearchString is null ? String.Empty : phoneNumberSearchString;
			var contactPeople = _contactPersonService.GetAllForList(pageSize, pageNumber.Value, firstNameSearchString, lastNameSearchString, emailSearchString, phoneNumberSearchString, roleSearchString, companySearchString);
			return View(contactPeople);
		}

		[HttpGet]
        public IActionResult Create(int companyId)
        {
            var roles = _contactPersonService.GetPersonRoles().ToList();
            var vm = new AddContactPersonVm()
            {
                Roles = roles,
                CompanyId = companyId
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddContactPersonVm person)
        {
            _contactPersonService.AddContactPerson(person);
            return RedirectToAction("Details", "Company", new { @id = person.CompanyId });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var personVm = _contactPersonService.GetContactPerson(id);
            return View(personVm);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var person = _contactPersonService.GetContactPerson(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Delete(ContactPersonVm personVm)
        {
            _contactPersonService.DeleteContactPerson(personVm.Id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var company = _contactPersonService.GetContactPersonForEdit(id);
            return View(company);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AddContactPersonVm personVm)
        {
            _contactPersonService.EditContactPerson(personVm);
            return RedirectToAction("Details", new { @id = personVm.Id });
        }
    }
}
