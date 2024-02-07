using CrmMVC.Application.Interfaces;
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
            var companies = _companyService.GetAll();
            return View(companies);
        }


        [HttpGet]
        public IActionResult AddCompany() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult AddCompany(CompanyVm company)
        {
            _companyService.AddCompany(company);
            return RedirectToAction(nameof(AddCompany));
        }

    }
}
