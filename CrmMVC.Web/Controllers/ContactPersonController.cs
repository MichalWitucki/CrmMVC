using Microsoft.AspNetCore.Mvc;
using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.Company;
using System.Collections.Generic;
using CrmMVC.Application.Services;
using CrmMVC.Application.ViewModels.ContactPerson;
using System.Linq;

namespace CrmMVC.Web.Controllers
{
    public class ContactPersonController : Controller
    {
        private readonly IContactPersonService _contactPersonService;

        public ContactPersonController(IContactPersonService contactPersonService)
        {
            _contactPersonService = contactPersonService;
        }

        public IActionResult Index()
        {
            var contactPeople = _contactPersonService.GetAll();
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
    }
}
