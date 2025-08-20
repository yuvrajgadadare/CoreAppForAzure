using Microsoft.AspNetCore.Mvc;

namespace CoreAppForAzure.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
