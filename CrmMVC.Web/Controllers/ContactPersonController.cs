﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Create(int id)
        {
            var roles = _contactPersonService.GetPersonRoles().ToList();
            var vm = new AddContactPersonVm()
            {
                Roles = roles,
                CompanyId = id
            };
            return View(vm);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create() 
        //{
        //    return View();
        //}
    }
}
