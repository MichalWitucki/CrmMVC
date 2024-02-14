using Microsoft.AspNetCore.Mvc;
using CrmMVC.Application.Interfaces;
using CrmMVC.Application.ViewModels.Company;
using System.Collections.Generic;

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
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create() 
        //{
        //    return View();
        //}
    }
}
