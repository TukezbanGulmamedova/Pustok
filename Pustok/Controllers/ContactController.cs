﻿using Microsoft.AspNetCore.Mvc;

namespace Pustok.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
