using CrmMVC.Application.Services;
using CrmMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace CrmMVC.Web.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            var companiesModel = companyService.GetAllCompaniesForList();
            return View(companiesModel);
        }

        [HttpGet]
        public IActionResult AddCompany() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult AddCompany(CompanyModel companyModel)
        { 
            var id = companyService.AddCompany(companyModel);
            return View(); 
        }

        [HttpGet]
        public IActionResult AddContactPersonToCompany(int companyId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContactPersonToCompany(ContactPersonModel contactPersonModel)
        {
            return View();
        }

        //[HttpGet]
        public IActionResult ShowCompany(int companyId)
        {
            var companyModel = companyService.GetCompanyDetails(companyId);
            return View(companyModel);
        }
    }
}
