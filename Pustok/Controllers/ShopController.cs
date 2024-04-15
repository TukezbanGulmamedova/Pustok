using Microsoft.AspNetCore.Mvc;

namespace Pustok.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
    }
}
