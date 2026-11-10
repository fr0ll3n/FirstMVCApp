using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebAppMVC.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult ById()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
