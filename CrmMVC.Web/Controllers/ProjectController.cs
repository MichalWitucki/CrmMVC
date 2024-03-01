using Microsoft.AspNetCore.Mvc;

namespace CrmMVC.Web.Controllers
{
	public class ProjectController : Controller
	{
        public ProjectController()
        {
            
        }

        public IActionResult Index()
		{
			return View();
		}
	}
}
