﻿using CrmMVC.Application.Interfaces;
using CrmMVC.Application.Services;
using CrmMVC.Application.ViewModels.Company;
using CrmMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace CrmMVC.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var companiesModel = _companyService.GetAllCompaniesForList();
            return View(companiesModel);
        }


        [HttpGet]
        public IActionResult AddCompany() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult AddCompany(NewCompanyVM model)
        {
            _companyService.AddCompany(model);
            return RedirectToAction(nameof(AddCompany));
        }

        //[HttpGet]
        //public IActionResult AddContactPersonToCompany(int companyId)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddContactPersonToCompany(ContactPersonModel contactPersonModel)
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult ShowCompany(int companyId)
        //{
        //    var companyModel = _companyService.GetCompanyDetails(companyId);
        //    return View(companyModel);
        //}
    }
}
