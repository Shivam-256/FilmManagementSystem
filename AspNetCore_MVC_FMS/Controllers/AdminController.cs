using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC_FMS.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
