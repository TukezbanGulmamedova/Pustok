using Microsoft.AspNetCore.Mvc;

namespace Pustok.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
