using Microsoft.AspNetCore.Mvc;

namespace Pustok.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Pages()
        {
            return View();
        }
    }
}
