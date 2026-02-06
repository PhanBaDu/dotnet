using Microsoft.AspNetCore.Mvc;

namespace SV22T1020073.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
