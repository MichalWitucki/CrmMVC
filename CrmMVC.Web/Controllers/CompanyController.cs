using Microsoft.AspNetCore.Mvc;

namespace CrmMVC.Web.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
