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
        public IActionResult Create()
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
            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Delete(int id)
        {
            _companyService.DeleteCompany(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
