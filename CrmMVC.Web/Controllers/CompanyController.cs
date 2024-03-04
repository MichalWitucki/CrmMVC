using CrmMVC.Application.Interfaces;
using CrmMVC.Application.Services;
using CrmMVC.Application.ViewModels.Company;
using CrmMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.Design;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CrmMVC.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly ILogger<CompanyController> _logger;
        public CompanyController(ICompanyService companyService, ILogger<CompanyController> logger)
        {
            _logger = logger;
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //_logger.LogWarning("SSSSSSSSSSSSSS");
            var companies = _companyService.GetAllForList(10,1, "", "", "", "");
            return View(companies);
        }

        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(int pageSize, int? pageNumber, string companyNameSearchString, string voivodeshipSearchString, string citySearchString, string companyTypeSearchString)
        {
            //_logger.LogWarning("ddddddddddddddddd");
            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }
            companyNameSearchString = companyNameSearchString is null ? String.Empty : companyNameSearchString;
			citySearchString = citySearchString is null ? String.Empty : citySearchString;
            var companies = _companyService.GetAllForList(pageSize, pageNumber.Value, companyNameSearchString, voivodeshipSearchString, citySearchString, companyTypeSearchString);
            return View(companies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //_logger.LogWarning("dddffffffffff");
            var voivodeships = _companyService.GetVoivodeships().ToList();
            var companyTypes = _companyService.GetCompanyTypes().ToList();
            var vm = new AddCompanyVm()
            {
                Voivodeships = voivodeships,
                CompanyTypes = companyTypes,
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddCompanyVm company)
        {
            _companyService.AddCompany(company);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id) 
        {
            var company = _companyService.GetCompany(id);
            return View(company);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var company = _companyService.GetCompanyForEdit(id); 
            var voivodeships = _companyService.GetVoivodeships().ToList();
            var companyTypes = _companyService.GetCompanyTypes().ToList();
            company.Voivodeships = voivodeships;
            company.CompanyTypes = companyTypes;
            return View(company);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AddCompanyVm company)
        {
            _companyService.UpdateCompany(company);
            return RedirectToAction("Details", new { @id = company.Id });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var company = _companyService.GetCompany(id);
            return View(company);
        }

        [HttpPost]
        public IActionResult Delete(CompanyVm company)
        {
            _companyService.DeleteCompany(company.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
