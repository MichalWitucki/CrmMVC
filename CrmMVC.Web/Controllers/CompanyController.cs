using CrmMVC.Application.Interfaces;
using CrmMVC.Application.Services;
using CrmMVC.Application.ViewModels.Company;
using CrmMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
        public IActionResult AddCompany(AddCompanyVm company)
        {
            _companyService.AddCompany(company);
            return RedirectToAction(nameof(AddCompany));
        }

    }
}
