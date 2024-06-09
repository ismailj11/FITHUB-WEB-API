using Microsoft.AspNetCore.Mvc;

namespace FITHUB_WEB_API.Controllers
{
    public class ProductCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
